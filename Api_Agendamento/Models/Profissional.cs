namespace Api_Agendamento.Models
{
    public class Profissional
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string? Telefone { get; set; }
        public string CpfCnpj { get; set; }
        public RamoProfissional RamoProfissional { get; set; }
        public ICollection<Servico> Servicos { get; set; } = new List<Servico>();
    }
}
