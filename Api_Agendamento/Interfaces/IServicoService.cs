using Api_Agendamento.DTOs;

namespace Api_Agendamento.Interfaces
{
    public interface IServicoService
    {
        Task<ServicoDTO> CriarServicoAsync(ServicoDTO servico);
        Task<bool> AlterarServicoAsync(ProfissionalDTO profissional, int id);
        Task<bool> ExcluirServicoAsync(int id);
        Task<IEnumerable<ServicoDTO>> ListarServicoAsync();

    }
}
