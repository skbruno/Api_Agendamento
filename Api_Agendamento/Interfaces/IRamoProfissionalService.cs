using Api_Agendamento.DTOs;
using System.Threading.Tasks;

namespace Api_Agendamento.Interfaces
{
    public interface IRamoProfissionalService
    {
        Task<RamoProfissionalDTO> CriarRamoAsync(RamoProfissionalDTO ramo);
        Task<bool> ExcluirRamoAsync(int id);
    }
}
