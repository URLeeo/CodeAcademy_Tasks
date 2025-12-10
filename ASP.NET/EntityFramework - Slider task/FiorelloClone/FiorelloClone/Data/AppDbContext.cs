using FiorelloClone.Models;
using Microsoft.EntityFrameworkCore;

namespace FiorelloClone.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Slider> Sliders { get; set; }
}
