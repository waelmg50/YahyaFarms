using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YahyaFarms.Models;

namespace YahyaFarms.Web.Data
{
    public class YahyaFarmsWebDbContext : DbContext
    {
        public YahyaFarmsWebDbContext (DbContextOptions<YahyaFarmsWebDbContext> options)
            : base(options)
        {
        }

        public DbSet<YahyaFarms.Models.Item> Item { get; set; } = default!;
        public DbSet<ItemImage> ItemsImages { get; set; } = default!;
    }
}
