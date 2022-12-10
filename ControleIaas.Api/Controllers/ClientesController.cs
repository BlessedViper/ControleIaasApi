using AutoMapper;
using ControleIaas.Domain.Dtos.Post;
using ControleIaas.Domain.Dtos.Update.Clientes;
using ControleIaas.Domain.Entities;
using ControleIaas.Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleIaas.Api.Controllers
{

    [Route("api")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        [HttpGet]
        [Route("v1/[controller]")]
        public async Task<List<Clientes>> Get([FromServices] IGetObjectFilter get)
        {
            return await get.GetObj<Clientes>();
        }

        [HttpGet]
        [Route("v1/[controller]/{id}")]
        public async Task<Clientes> GetId(
            [FromServices] IGetObjectFilter get,
            int id)
        {
            return await get.GetObjId<Clientes>(id);
        }

        [HttpGet]
        [Route("v1/[controller]/All")]
        public async Task<List<Clientes>> GetNoFilter([FromServices] IGetObject get)
        {
            return await get.GetObj<Clientes>();
        }

        [HttpPost]
        [Route("v1/[controller]")]
        public async Task<IActionResult> Post(
            [FromServices] IPostObject post,
            [FromServices] IMapper mapper,
            [FromBody] CreateClientesDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = mapper.Map<Clientes>(dto);
                var result = await post.SaveObject(obj);
                return CreatedAtAction(nameof(Post), dto);
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
            var cliente = await delete.GetDelete<Clientes>(id);

            if (cliente is null)
                return NotFound();

            delete.DeleteObj(cliente);

            return NoContent();
        }

        [HttpPut]
        [Route("v1/[controller]/Ambiente")]
        public async Task<IActionResult> Update(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateClientesAmbienteDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Clientes>(dto.Id);
                if (obj is null)
                    return NotFound();

                obj.IdAmbiente = dto.IdAmbiente;

                update.Update(obj);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("v1/[controller]/Versao")]
        public async Task<IActionResult> UpdateVersao(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateClientesVersaoDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Clientes>(dto.Id);
                if (obj is null)
                    return NotFound();

                obj.IdVersao = dto.IdVersao;

                update.Update(obj);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("v1/[controller]/Nome")]
        public async Task<IActionResult> UpdateNome(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateClientesNomeDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Clientes>(dto.Id);
                if (obj is null)
                    return NotFound();

                obj.Nome = dto.Nome;

                update.Update(obj);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("v1/[controller]/Instancia")]
        public async Task<IActionResult> UpdateInstancia(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateClientesInstanciaDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Clientes>(dto.Id);
                if (obj is null)
                    return NotFound();

                obj.IdInstancia = dto.IdInstancia;

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
        public async Task<IActionResult> AtivarInstancia(
            [FromServices] IActiveObject active,
            int id)
        {
            try
            {
                var obj = await active.GetActive<Instancias>(id);

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
