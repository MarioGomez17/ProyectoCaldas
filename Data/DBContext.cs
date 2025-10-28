using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyecto_caldas.Models;

namespace proyecto_caldas.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioModel>().HasKey(U => U.Usuario_Id);
            modelBuilder.Entity<UsuarioModel>().Property(U => U.Usuario_Id).ValueGeneratedOnAdd();
        }
    }
}