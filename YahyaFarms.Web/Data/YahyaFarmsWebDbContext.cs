using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YahyaFarms.Models;

namespace YahyaFarms.Web.Data
{
    public class YahyaFarmsWebDbContext(DbContextOptions<YahyaFarmsWebDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<YahyaFarms.Models.Item> Items { get; set; } = default!;
        public DbSet<ItemImage> ItemsImages { get; set; } = default!;
        public DbSet<AdminUser> AdminUsers { get; set; }
    }
}
