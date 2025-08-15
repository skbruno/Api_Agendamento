using Api_Agendamento.Context;
using Api_Agendamento.DTOs;
using Api_Agendamento.Interfaces;
using Api_Agendamento.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Api_Agendamento.Services
{
    //Ficar responsavel pela criação de agendamento/remarcação e etc
    public class AgendamentoService : IAgendamentoService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AgendamentoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<AgendamentoDTO> CriarAgendamentoAsync(AgendamentoDTO agendamento)
        {
            var lAgendamento = _mapper.Map<Agendamento>(agendamento);
            await _context.Agendamentos.AddAsync(lAgendamento);
            await _context.SaveChangesAsync();

            var agendamentoDTO = _mapper.Map<AgendamentoDTO>(lAgendamento); 
            return agendamentoDTO; 
        }

        public Task<bool> AlterarAgendamentoAsync(AgendamentoDTO agendamento, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExcluirAgendamentoAsync(int id)
        {
            var idAgendamento = await _context.Agendamentos.FirstOrDefaultAsync(x => x.Id == id);

            if (idAgendamento == null)
                return false;

            _context.Remove(idAgendamento);
            var estadoObj = _context.Entry(idAgendamento);

            if (estadoObj.State == EntityState.Deleted)
            {
                _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<int> BuscarAgendamentoAsync(int id)
        {
            var idAgendamento = await _context.Agendamentos.FirstOrDefaultAsync(x => x.Id == id);

            if (idAgendamento == null)
                return 0;

            return idAgendamento.Id;
        }

        public async Task<IEnumerable<AgendamentoDTO>> ObterAgendamentosAsync()
        {
            var agendamentos = await _context.Agendamentos.AsNoTracking().ToListAsync();

            return _mapper.Map<IEnumerable<AgendamentoDTO>>(agendamentos);
        }
    }
}
