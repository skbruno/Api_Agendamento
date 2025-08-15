namespace Api_Agendamento.Models
{
    public class Cliente : UsuarioBase
    {
        public int Idade { get; set; }
        public ICollection<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();
    }
}
