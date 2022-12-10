using AutoMapper;
using ControleIaas.Domain.Dtos.Post;
using ControleIaas.Domain.Dtos.Update;
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
    public class VersaoContradaController : ControllerBase
    {

        [HttpGet]
        [Route("v1/[controller]")]
        public async Task<List<VersaoContr>> Get([FromServices] IGetObjectFilter get)
        {
            return await get.GetObj<VersaoContr>();
        }

        [HttpGet]
        [Route("v1/[controller]/{id}")]
        public async Task<VersaoContr> GetById(
            [FromServices] IGetObjectFilter get,
            int id)
        {
            return await get.GetObjId<VersaoContr>(id);

        }

        [HttpGet]
        [Route("v1/[controller]/listar")]
        public async Task<List<VersaoContr>> GetAll([FromServices] IGetObject get)
        {
            return await get.GetObj<VersaoContr>();
        }

        [HttpPost]
        [Route("v1/[controller]")]
        public async Task<IActionResult> Post(
            [FromServices] IPostObject post,
            [FromServices] IMapper mapper,
            [FromBody] CreateVersaoContrDto versaoContrDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var versao = mapper.Map<VersaoContr>(versaoContrDto);
                var result = await post.SaveObject(versao);
                return CreatedAtAction(nameof(Post), versao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("v1/[controller]/{id}")]
        public async Task<IActionResult> Delete(
            [FromServices] IDeleteObject delete,
            int id)
        {

            var versao = await delete.GetDelete<VersaoContr>(id);

            if (versao is null)
                return NotFound();

            delete.DeleteObj<VersaoContr>(versao);
            return Ok();
        }

        [HttpPut]
        [Route("v1/[controller]/versao")]
        public async Task<IActionResult> Update(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateVersaoContratadaDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var obj = await update.TesteUpdate<VersaoContr>(dto.Id);
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
        [Route("v1/[controller]/{id}/Active")]
        public async Task<IActionResult> Active(
            [FromServices] IActiveObject active,
            int id)
        {
            try
            {
                var obj = await active.GetActive<VersaoContr>(id);

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
