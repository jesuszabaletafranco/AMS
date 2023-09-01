using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMS.Models;
using Microsoft.EntityFrameworkCore;

namespace AMS.Data
{
    public class AmsContext : DbContext
    {
        public AmsContext(DbContextOptions<AmsContext> options) : base(options)
        {
            
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioRole> UsuariosRoles { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuario_AMS")
                .HasKey(x => new { x.UsuarioID });
            modelBuilder.Entity<Role>().ToTable("Roles");
            modelBuilder.Entity<UsuarioRole>().ToTable("Usuario_Roles");
        }
    }
    
}
