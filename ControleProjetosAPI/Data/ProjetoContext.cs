using ControleProjetosAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ControleProjetosAPI.Data;

public class ProjetoContext : DbContext
{
	public DbSet<Projeto> Projetos { get; set; }
    public DbSet<Tasks> Tasks { get; set; }
    public DbSet<TimeTracker> TimeTrackers { get; set; }
    public DbSet<Collaborators> Collaborators { get; set; }
    public DbSet<Users> Users { get; set; }

    public ProjetoContext(DbContextOptions<ProjetoContext> opts) : base(opts)
	{

	}
}
