namespace Api_Agendamento.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public string? NomeServico { get; set; }
        public double Preco { get; set; }
        public int DuracaoMinutos { get; set; }
    }
}
