using Microsoft.EntityFrameworkCore;
using PogoRaidBot.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PogoRaidBot.Web.Data
{
    public class PogoRaidBotWebDbContext : DbContext
    {
        private string connectionString;

        public PogoRaidBotWebDbContext(string cstr)
        {
            connectionString = cstr;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OAuthCodeEntity>().HasKey(c => c.Id);
        }

        public DbSet<OAuthCodeEntity> OAuthCodes { get; set; }
    }
}
