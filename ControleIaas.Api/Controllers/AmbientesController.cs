using AutoMapper;
using ControleIaas.Domain.Dtos.Post;
using ControleIaas.Domain.Dtos.Update.Ambiente;
using ControleIaas.Domain.Entities;
using ControleIaas.Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleIaas.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class AmbientesController : ControllerBase
    {

        [HttpGet]
        [Route("v1/[controller]")]
        public async Task<List<Ambientes>> GetAmbientesAtivos([FromServices] IGetObjectFilter getObj)
        {
            return await getObj.GetObj<Ambientes>();
        }

        [HttpGet]
        [Route("v1/[controller]/{id}")]
        public async Task<Ambientes> GetAmbienteId(
            [FromServices] IGetObjectFilter getObj,
            int id)
        {
            return await getObj.GetObjId<Ambientes>(id);
        }

        [HttpGet]
        [Route("v1/[controller]/all")]
        public async Task<List<Ambientes>> GetAmbientesSemFiltro([FromServices] IGetObject getObject)
        {
            return await getObject.GetObj<Ambientes>();
        }

        [HttpPost]
        [Route("v1/[controller]")]
        public async Task<IActionResult> IncluiAmbiente(
            [FromServices] IPostObject postObj,
            [FromBody] CreateAmbientesDto ambienteDto,
            [FromServices] IMapper mapper)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = mapper.Map<Ambientes>(ambienteDto);

                var result = await postObj.SaveObject(obj);

                return CreatedAtAction(nameof(GetAmbienteId), new { result.Id }, result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("v1/[controller]/{id}")]
        public async Task<IActionResult> DeleteAmbiente(
            [FromServices] IDeleteObject deleteObj,
            int id)
        {
            var ambiente = await deleteObj.GetDelete<Ambientes>(id);

            if (ambiente is null)
                return NotFound();

            deleteObj.DeleteObj(ambiente);

            return NoContent();
        }

        [HttpPut]
        [Route("v1/[controller]/Versao")]
        public async Task<IActionResult> Update(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateAmbientesVersaoDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Ambientes>(dto.Id);
                if (obj is null)
                    return NotFound();

                obj.Versao = dto.Versao;

                update.Update(obj);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("v1/[controller]/{id}/Ativar")]
        public async Task<IActionResult> AtivarAmbiente(
            [FromServices] IActiveObject active,
            int id)
        {
            try
            {
                var obj = await active.GetActive<Ambientes>(id);

                if (obj is null)
                    return NotFound();

                await active.Active(obj);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
