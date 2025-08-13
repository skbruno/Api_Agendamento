namespace Api_Agendamento.DTOs
{
    public class ServicoDTO
    {
        public int Id { get; set; }
        public string? NomeServico { get; set; }
        public double Preco { get; set; }
        public int DuracaoMinutos { get; set; }
    }
}
