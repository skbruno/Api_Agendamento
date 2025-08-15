namespace Api_Agendamento.Models
{
    public class Profissional : UsuarioBase
    {
        public ICollection<RamoProfissional> RamoProfissional { get; set; } = new List<RamoProfissional>();
        public ICollection<Servico> Servicos { get; set; } = new List<Servico>();
    }
}
