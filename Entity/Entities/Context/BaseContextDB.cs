using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities.Context
{
    public class BaseContextDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=GWTRIS-M-L1003\\SQLEXPRESS01;Database=BaseDB;Trusted_Connection=True;");
        }

        public DbSet <User> Users { get; set; }
    }
}
