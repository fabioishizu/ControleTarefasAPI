using ControleProjetosAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ControleProjetosAPI.Data;

public class ProjetoContext : DbContext
{
	public DbSet<Projeto> Projetos { get; set; }

	public ProjetoContext(DbContextOptions<ProjetoContext> opts) : base(opts)
	{

	}
}
