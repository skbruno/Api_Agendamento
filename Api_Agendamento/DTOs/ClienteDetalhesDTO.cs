using Api_Agendamento.Models;

namespace Api_Agendamento.DTOs
{
    public class ClienteDetalhesDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string? Telefone { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public ICollection<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();
    }
}
