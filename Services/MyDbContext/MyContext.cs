using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.MyDbContext
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDatabase");
        }

        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<EMedico> EMedicos { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<UsuarioRol> UsuarioRols { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clinica>()
                .HasMany(clinica => clinica.usuarios)
                .WithOne(usuarios => usuarios.clinica)
                .HasForeignKey(usuarios => usuarios.clinicaId);

            modelBuilder.Entity<Usuario>()
                .HasOne(usuario => usuario.eMedico)
                .WithOne(eMedico => eMedico.usuario)
                .HasForeignKey<EMedico>(eMedico => eMedico.UsuarioId);

            modelBuilder.Entity<Usuario>()
                .HasMany(usuarios => usuarios.rols)
                .WithMany(rols => rols.usuarios)
                .UsingEntity<UsuarioRol>();
        }
    }
}
