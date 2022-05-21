using DemianCRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DemianCRUD.Models.DAO
{
    public class DemianCRUDContext : DbContext
    {

        public DemianCRUDContext(DbContextOptions<DemianCRUDContext> options) : base(options) 
        {
        }
        public DbSet<Pessoa> Pessoa { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.HasKey(x => x.id);
                entity.Property(x => x.nome).IsRequired();
                entity.Property(x => x.email).IsRequired();
                entity.Property(x => x.Cpf);
                entity.Property(x => x.telefone);
                entity.Property(x => x.habilitacao).IsRequired();
                entity.Property(x => x.categoria);
                entity.Property(x => x.linguaEstrangeira);
                entity.Property(x => x.estado);
                entity.Property(x => x.cidade);
                entity.Property(x => x.cep);
                entity.Property(x => x.logadouro);
                entity.Property(x => x.numero);
                entity.Property(x => x.complemento);
                entity.Property(x => x.cargo);
                entity.Property(x => x.salarioProposto);

            } );
                 
        }



    }
}
