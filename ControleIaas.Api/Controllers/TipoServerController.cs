using AutoMapper;
using ControleIaas.Domain.Dtos.Post;
using ControleIaas.Domain.Dtos.Update.TipoServer;
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
    public class TipoServerController : ControllerBase
    {

        [HttpGet]
        [Route("v1/[controller]")]
        public async Task<List<TipoServer>> GetTipo([FromServices] IGetObjectFilter get)
        {
            return await get.GetObj<TipoServer>();
        }

        [HttpGet]
        [Route("v1/[controller]/{id}")]
        public async Task<TipoServer> GetTipoId(
            [FromServices] IGetObjectFilter get,
            int id)
        {
            return await get.GetObjId<TipoServer>(id);
        }
        [HttpGet]
        [Route("v1/[controller]/listar")]
        public async Task<List<TipoServer>> GetTipoAll([FromServices] IGetObject get)
        {
            return await get.GetObj<TipoServer>();
        }

        [HttpPost]
        [Route("v1/[controller]")]
        public async Task<IActionResult> PostTipoServer(
            [FromServices] IPostObject post,
            [FromServices] IMapper mapper,
            [FromBody] CreateTipoServerDto tipoServerDto)
        {
            if (ModelState.IsValid)
            {
                TipoServer tipoServer = mapper.Map<TipoServer>(tipoServerDto);
                var result = await post.SaveObject(tipoServer);
                return CreatedAtAction(nameof(PostTipoServer), new { result.Id }, tipoServerDto);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        [Route("v1/[controller]/{id}")]
        public async Task<IActionResult> DeleteTipo(
            [FromServices] IDeleteObject delete,
            int id)
        {

            var tipoServer = await delete.GetDelete<TipoServer>(id);

            if (tipoServer is null)
                return NotFound();

            delete.DeleteObj(tipoServer);
            return Ok();
        }

        [HttpPut]
        [Route("v1/[controller]/Descricao")]
        public async Task<IActionResult> Update(
            [FromServices] IUpdateObject update,
            [FromServices] IMapper mapper,
            [FromBody] UpdateTipoServerDescricaoDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {

                var obj = await update.TesteUpdate<TipoServer>(dto.Id);
                if (object.ReferenceEquals(obj, null))
                    return NotFound();


                obj = mapper.Map<TipoServer>(dto);
                update.Update(obj);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("v1/[controller]/Servico")]
        public async Task<IActionResult> Update(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateTipoServerServicosDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var obj = await update.TesteUpdate<TipoServer>(dto.Id);

                if (object.ReferenceEquals(obj, null))
                    return NotFound();

                obj.Servicos = dto.Servicos;

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
                var obj = await active.GetActive<TipoServer>(id);

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
