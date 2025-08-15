using Api_Agendamento.Models;
using Microsoft.EntityFrameworkCore;


namespace Api_Agendamento.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
        {

        }

        public DbSet<Agendamento>? Agendamentos { get; set; }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Profissional> Profissionals { get; set; }
        public DbSet<RamoProfissional> RamoProfissionals { get; set; }
        public DbSet<Servico> Servicos { get; set; }
    }
}
