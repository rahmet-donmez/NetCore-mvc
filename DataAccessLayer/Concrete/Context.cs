﻿using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=Ticaret; integrated security=true;");


        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Offer> Offers { get; set; }



    }

}
