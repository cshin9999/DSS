using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Text.Json;

namespace DSS.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Configuration> Configurations => Set<Configuration>();
        public DbSet<Carrier> Carriers => Set<Carrier>();
        public DbSet<Shared.Client> Clients => Set<Shared.Client>();
    }
}
