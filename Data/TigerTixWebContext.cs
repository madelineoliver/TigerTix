using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TigerTix.Web.Models;

namespace TigerTix.Web.Data
{
    public class TigerTixWebContext : DbContext
    {

        
        public DbSet<TigerTix.Web.Models.User> User { get; set; }

        public DbSet<TigerTix.Web.Models.Event> Event { get; set; }

        private readonly IConfiguration _config;

        public TigerTixWebContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);
        }

        

    }
}
