using Api_Agendamento.Models;
using AutoMapper;

namespace Api_Agendamento.DTOs.Mappings
{
    public class AgendamentoDTOMappingProfile : Profile
    {
        public AgendamentoDTOMappingProfile()
        {
            CreateMap<Agendamento, AgendamentoDTO>().ReverseMap();
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
            CreateMap<Cliente, ClienteDetalhesDTO>().ReverseMap();
            CreateMap<Profissional, ProfissionalDTO>().ReverseMap();
            CreateMap<Profissional, ProfissionalDetalhesDTO>().ReverseMap();
            CreateMap<RamoProfissional, RamoProfissionalDTO>().ReverseMap();
            CreateMap<Servico, ServicoDTO>().ReverseMap();

        }
    }
}
