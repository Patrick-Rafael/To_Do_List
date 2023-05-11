using Microsoft.EntityFrameworkCore;

namespace To_Do.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes ): base (opcoes)
        {
        }

    }
}
