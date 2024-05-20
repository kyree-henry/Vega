using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Presistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        { }

        public DbSet<Model> Models { get; set; }
        public DbSet<Make> Makes { get; set; }
    }
}