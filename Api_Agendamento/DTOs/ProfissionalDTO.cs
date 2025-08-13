using Api_Agendamento.Models;

namespace Api_Agendamento.DTOs
{
    public class ProfissionalDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string? Telefone { get; set; }
        public string CpfCnpj { get; set; }
    }
}
