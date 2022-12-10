using AutoMapper;
using ControleIaas.Domain.Dtos.Post;
using ControleIaas.Domain.Dtos.Update.Maquinas;
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
    public class MaquinasController : ControllerBase
    {

        [HttpGet]
        [Route("v1/[controller]")]
        public async Task<List<Maquinas>> GetMaquinas([FromServices] IGetObjectFilter get)
        {
            return await get.GetObj<Maquinas>();
        }

        [HttpGet]
        [Route("v1/[controller]/{id}")]
        public async Task<Maquinas> GetMaquinaId([FromServices] IGetObjectFilter get,
            int id)
        {
            return await get.GetObjId<Maquinas>(id);
        }

        [HttpGet]
        [Route("v1/[controller]/listar")]
        public async Task<List<Maquinas>> GetMaquinasAll([FromServices] IGetObject get)
        {
            return await get.GetObj<Maquinas>();
        }

        [HttpPost]
        [Route("v1/[controller]")]
        public async Task<IActionResult> PostMaquinas(
            [FromServices] IPostObject post,
            [FromServices] IMapper mapper,
            [FromBody] CreateMaquinasDto obj)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                Maquinas maquina = mapper.Map<Maquinas>(obj);
                var result = await post.SaveObject(maquina);
                return CreatedAtAction(nameof(PostMaquinas), new { maquina.Id }, obj);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("v1/[controller]/{id}")]
        public async Task<IActionResult> DeleteMaquinas(
            [FromServices] IDeleteObject delete,
            int id)
        {
            var maquina = await delete.GetDelete<Maquinas>(id);

            if (maquina is null)
                return NotFound();

            delete.DeleteObj<Maquinas>(maquina);
            return Ok();
        }

        [HttpPut]
        [Route("v1/[controller]/Ambiente")]
        public async Task<IActionResult> UpdateAmbiente(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateMaquinasAmbienteDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Maquinas>(dto.Id);
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
        [Route("v1/[controller]/TipoServer")]
        public async Task<IActionResult> UpdateTipo(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateMaquinasTipoDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Maquinas>(dto.Id);
                if (obj is null)
                    return NotFound();

                obj.IdTipo = dto.IdTipo;

                update.Update(obj);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("v1/[controller]/SistemaOperacional")]
        public async Task<IActionResult> Update(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateMaquinasSoDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Maquinas>(dto.Id);
                if (obj is null)
                    return NotFound();

                obj.SO = dto.SO;

                update.Update(obj);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("v1/[controller]/IpPrivado")]
        public async Task<IActionResult> UpdateIp(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateMaquinasIpPrivadoDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Maquinas>(dto.Id);
                if (obj is null)
                    return NotFound();

                obj.IpPrivado = dto.IpPrivado;

                update.Update(obj);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("v1/[controller]/NomeDns")]
        public async Task<IActionResult> UpdateDns(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateMaquinasNomeDnsDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Maquinas>(dto.Id);
                if (obj is null)
                    return NotFound();

                obj.NomeDns = dto.NomeDns;

                update.Update(obj);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("v1/[controller]/PortaRdp")]
        public async Task<IActionResult> UpdatePortaRdp(
            [FromServices] IUpdateObject update,
            [FromBody] UpdateMaquinasPortaDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Maquinas>(dto.Id);
                if (obj is null)
                    return NotFound();

                obj.PortaRdp = dto.PortaRdp;

                update.Update(obj);

                return Ok();
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
            [FromBody] UpdateMaquinasUsuarioDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Maquinas>(dto.Id);
                if (obj is null)
                    return NotFound();

                obj.Usuario = dto.Usuario;

                update.Update(obj);

                return Ok();
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
            [FromBody] UpdateMaquinasSenhaDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var obj = await update.TesteUpdate<Maquinas>(dto.Id);
                if (obj is null)
                    return NotFound();

                obj.Senha = dto.Senha;

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
                var obj = await active.GetActive<Maquinas>(id);

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
