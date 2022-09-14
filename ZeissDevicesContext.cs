using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBInteraction
{
    public class ZeissDevicesContext:DbContext
    {
        public DbSet<Device> Devices { get; set; }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-7LJ7HTPU\SQLEXPRESS;Initial Catalog=ZeissDevicesDb;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>().Property(p => p.Description).IsRequired(false);
        }
    }

}
