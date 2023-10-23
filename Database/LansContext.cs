using Microsoft.EntityFrameworkCore;

namespace Database;

public class LansContext: DbContext
{
	public LansContext(DbContextOptions<LansContext> options) : base (options)
	{
		
	}

	public DbSet<Empleado> Empleados { get; set;}
	public DbSet<Rol> Roles { get; set; }
}
