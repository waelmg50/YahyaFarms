using Microsoft.EntityFrameworkCore;
using YahyaFarms.Models;

namespace YahyaFarms.DBContext
{
    public class YahyaFarmsDBContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}
