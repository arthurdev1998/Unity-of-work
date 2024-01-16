using DesignerUnityOfWork.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignerUnityOfWork.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<Director> Directors { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Genre> Genre { get; set; }
}