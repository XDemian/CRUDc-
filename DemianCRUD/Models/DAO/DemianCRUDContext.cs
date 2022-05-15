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
                entity.Property(x => x.endereco).IsRequired();
                entity.Property(x => x.idade).IsRequired();
            } );
                 
        }



    }
}
