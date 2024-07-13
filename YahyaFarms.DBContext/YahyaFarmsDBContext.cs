using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using YahyaFarms.Models;

namespace YahyaFarms.DBContext
{
    public class YahyaFarmsDBContext : DbContext
    {

        #region Members

        private readonly IConfiguration _config;

        #endregion

        #region Constructor

        public YahyaFarmsDBContext(DbContextOptions<YahyaFarmsDBContext> options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        #endregion

        #region Models

        public DbSet<Item> Items { get; set; }

        #endregion

        #region Overrided Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DBConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.UseCollation("Arabic_CI_AS");
        }

        #endregion
    }
}
