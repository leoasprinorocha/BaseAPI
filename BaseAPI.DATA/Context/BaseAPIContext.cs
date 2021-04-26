using BaseAPI.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAPI.DATA.Context
{
    public class BaseAPIContext : DbContext
    {
        public BaseAPIContext(DbContextOptions<BaseAPIContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().
                HasData(
                new Cliente { ID = 1, Nome = "Leonardo Asprino Rocha" }

                );
        }

    }
}
