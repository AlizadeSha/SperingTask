using Microsoft.EntityFrameworkCore;
using System;

namespace SperingTask.DAL
{
    public class DbSperingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=CA-R214-PC11\\SQLEXPRESS;Database=DbSpering;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSperingContext(DbContextOptions<DbSperingContext> options) : base(options)
        {

        }
    }
}
