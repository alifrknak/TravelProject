using Microsoft.EntityFrameworkCore;

namespace Web.Models;

public class Context : DbContext
{
	public DbSet<Admin> Admins { get; set; }
	public DbSet<About> Abouts { get; set; }
	public DbSet<Address> Addresses { get; set; }
	public DbSet<Blog> Blogs { get; set; }
	public DbSet<Comment> Comments { get; set; }
	public DbSet<Contact> Contacts { get; set; }

	private IConfiguration configuration;
	public Context(IConfiguration configuration)
	{
		this.configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(configuration.GetConnectionString("MainDatabase"));
	}
	 
}
