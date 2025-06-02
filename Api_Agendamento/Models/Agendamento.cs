namespace Api_Agendamento.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public StatusPagamento StatusPagamento { get; set; }
        public Profissional? Profissional { get; set; }
        public Cliente? Cliente { get; set; }
        public ICollection<Servico> Servicos { get; set; } = new List<Servico>();
        public StatusAgendamento StatusAgendamento { get; set; }
        public string? Local { get; set; }
        public string? Observacao { get; set; }
    }
}
