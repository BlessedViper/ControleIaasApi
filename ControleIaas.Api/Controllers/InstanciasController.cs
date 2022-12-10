using AutoMapper;
using ControleIaas.Domain.Dtos.Post;
using ControleIaas.Domain.Dtos.Update.Instancias;
using ControleIaas.Domain.Entities;
using ControleIaas.Domain.Interface;
using ControleIaas.Domain.Interface.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleIaas.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class InstanciasController : ControllerBase
    {

        [HttpGet]
        [Route("v1/[controller]")]
        public async Task<List<Instancias>> GetInstancias([FromServices] IGetInstanciasCommand get)
        {
            return await get.GetInstancias();
        }

        [HttpGet]
        [Route("v1/[controller]/{id}")]
        public async Task<Instancias> GetInstanciasId(
            [FromServices] IGetObjectFilter get,
            int id)
        {
            var obj = await get.GetObjId<Instancias>(id);
            obj.Senha = Shared.Crip.Criptografia.Descriptografar(obj.Senha);
            return obj;
        }

        [HttpGet]
        [Route("v1/[controller]/All")]
        public async Task<List<Instancias>> GetInstanciasNoFilter([FromServices] IGetInstanciasFiltroCommand get)
        {
            return await get.GetInstancias();
        }

        [HttpPost]
        [Route("v1/[controller]")]
        public async Task<IActionResult> Post(
            [FromServices] IPostObject post,
            [FromServices] IMapper mapper,
            [FromBody] CreateInstanciasDto instanciaDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                Instancias instancia = mapper.Map<Instancias>(instanciaDto);
                instancia.Senha = ControleIaas.Shared.Crip.Criptografia.Criptografar(instanciaDto.Senha);
                var result = await post.SaveObject(instancia);
                return CreatedAtAction(nameof(Post), new { result.Id }, instanciaDto);
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

            var instancia = await delete.GetDelete<Instancias>(id);

            if (instancia is null)
                return NotFound();

            delete.DeleteObj<Instancias>(instancia);

            return NoContent();
        }

        [HttpPut]
        [Route("v1/[controller]/Instancia")]
        public async Task<IActionResult> UpdateInstancia(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateInstanciasInstanciaDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Instancias>(dto.Id);

                if (obj is null)
                    return NotFound();

                obj.Instancia = dto.Instancia;

                update.Update(obj);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("v1/[controller]/Maquina")]
        public async Task<IActionResult> UpdateServidor(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateInstanciasMaquinasDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Instancias>(dto.Id);
                if (obj is null)
                    return NotFound();
                obj.IdMaquina = dto.IdMaquina;

                update.Update(obj);

                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("v1/[controller]/Banco")]
        public async Task<IActionResult> UpdateBanco(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateInstanciasBancoDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Instancias>(dto.Id);

                if (obj is null)
                    return NotFound();

                obj.Banco = dto.Banco;

                update.Update(obj);

                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("v1/[controller]/Usuario")]
        public async Task<IActionResult> UpdateUsuario(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateInstanciasUsuarioDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Instancias>(dto.Id);

                if (obj is null)
                    return NotFound();

                obj.Usuario = dto.Usuario;

                update.Update(obj);

                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("v1/[controller]/Senha")]
        public async Task<IActionResult> UpdateSenha(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateInstanciasSenhaDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Instancias>(dto.Id);

                if (obj is null)
                    return NotFound();

                obj.Senha = ControleIaas.Shared.Crip.Criptografia.Criptografar(dto.Senha);

                update.Update(obj);

                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("v1/[controller]/{id}/Ativar")]
        public async Task<IActionResult> Active(
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
