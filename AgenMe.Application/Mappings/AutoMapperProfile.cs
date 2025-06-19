using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenMe.Application.DTOs;
using AgenMe.Domain.Entitie.AgenMe.Domain.Entities;
using AutoMapper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AgenMe.Application.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile()
            {
                // 🔹 Agendamento ↔ AgendamentoDto
                CreateMap<Agendamento, AgendamentoDto>()
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
                    .ReverseMap()
                    .ForMember(dest => dest.Status, opt => opt.Ignore()) // Status controlado pela entidade
                    .ForMember(dest => dest.DataCriacao, opt => opt.Ignore())
                    .ForMember(dest => dest.DataAtualizacao, opt => opt.Ignore());

                // 🔹 Servico ↔ ServicoDto
                CreateMap<Servico, ServicoDto>()
                    .ForMember(dest => dest.Duracao, opt => opt.MapFrom(src => src.Duracao.ToString(@"hh\:mm")))
                    .ReverseMap()
                    .ForMember(dest => dest.Duracao, opt => opt.MapFrom(src => TimeSpan.Parse(src.Duracao)))
                    .ForMember(dest => dest.DataCriacao, opt => opt.Ignore())
                    .ForMember(dest => dest.DataAtualizacao, opt => opt.Ignore());

                // 🔹 Usuario ↔ UsuarioDto
                CreateMap<Usuario, UsuarioDto>()
                    .ReverseMap()
                    .ForMember(dest => dest.DataCriacao, opt => opt.Ignore())
                    .ForMember(dest => dest.DataAtualizacao, opt => opt.Ignore())
                    .ForMember(dest => dest.Agendamentos, opt => opt.Ignore()) // Relacionamento gerenciado pelo domínio
                    .ForMember(dest => dest._agendamentos, opt => opt.Ignore());
            }
        }
    }
}
