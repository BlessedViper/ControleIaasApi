using AutoMapper;
using ControleIaas.Domain.Dtos.Delete;
using ControleIaas.Domain.Dtos.Get;
using ControleIaas.Domain.Dtos.Post;
using ControleIaas.Domain.Dtos.Update;
using ControleIaas.Domain.Dtos.Update.Ambiente;
using ControleIaas.Domain.Dtos.Update.Clientes;
using ControleIaas.Domain.Dtos.Update.Instancias;
using ControleIaas.Domain.Dtos.Update.Maquinas;
using ControleIaas.Domain.Dtos.Update.TipoServer;
using ControleIaas.Domain.Entities;
using System.Linq;

namespace ControleIaas.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Create To Entity
            CreateMap<CreateAmbientesDto, Ambientes>();
            CreateMap<CreateClientesDto, Clientes>();
            CreateMap<CreateInstanciasDto, Instancias>();
            CreateMap<CreateMaquinasDto, Maquinas>();
            CreateMap<CreateTipoServerDto, TipoServer>();
            CreateMap<CreateVersaoContrDto, VersaoContr>();
            #endregion

            #region Entity To Read
            CreateMap<Ambientes, ReadAmbientesDto>();
            CreateMap<Clientes, ReadClientesDto>();
            CreateMap<Instancias, ReadInstanciasDto>();
            CreateMap<Maquinas, ReadMaquinasDto>();
            CreateMap<TipoServer, ReadTipoServerDto>();
            CreateMap<VersaoContr, ReadVersaoContrDto>()
                .ForMember(vr => vr.Clientes, map => map
                .MapFrom(vr => vr.Clientes.Select
                (s => new { s.Id, s.Nome, s.Ambiente })));
            #endregion

            #region Delete To Entity
            CreateMap<DeleteAmbientesDto, Ambientes>();
            #endregion

            #region Update To Entity
            CreateMap<UpdateInstanciasSenhaDto, Instancias>();
            CreateMap<UpdateClientesNomeDto, Clientes>();
            CreateMap<UpdateAmbientesVersaoDto, Ambientes>();
            CreateMap<UpdateMaquinasSenhaDto, Maquinas>();
            CreateMap<UpdateTipoServerServicosDto, TipoServer>();
            CreateMap<UpdateVersaoContratadaDto, VersaoContr>();
            #endregion
        }
    }
}
