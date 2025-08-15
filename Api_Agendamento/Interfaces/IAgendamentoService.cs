using Api_Agendamento.DTOs;

namespace Api_Agendamento.Interfaces
{
    public interface IAgendamentoService
    {
        Task<AgendamentoDTO> CriarAgendamentoAsync(AgendamentoDTO agendamento);
        Task<bool> AlterarAgendamentoAsync(AgendamentoDTO agendamento, int id);
        Task<bool> ExcluirAgendamentoAsync(int id);
        Task<int> BuscarAgendamentoAsync(int id);
        Task<IEnumerable<AgendamentoDTO>> ObterAgendamentosAsync();
    }
}
