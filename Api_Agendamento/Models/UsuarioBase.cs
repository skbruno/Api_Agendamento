namespace Api_Agendamento.Models
{
    public abstract class UsuarioBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string? Telefone { get; set; }
        public string CpfCnpj { get; set; }
    }
}
