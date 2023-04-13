using System;
using DATA.Mapping;
using DATA.Mapping.Payment;
using Domain.Entidades.Estado;
using Domain.Entidades.Pagamento;
using Domain.Entidades.Usuarios;
using Microsoft.EntityFrameworkCore;

namespace DATA.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PaymentEntity> PaymentEntity { get; set; }
        public DbSet<PaymentLinhas> PaymentLinhas { get; set; }
        public DbSet<PaisEntity> PaisEntity { get; set; }
        public DbSet<EstadoEntity> EstadoEntity { get; set; }
        public DbSet<MunicipioEntity> MunicipioEntity { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<PaymentEntity>(new PaymentMap().Configure);
            modelBuilder.Entity<PaymentLinhas>(new PaymentMap().Configure);
            modelBuilder.Entity<PaisEntity>(new PaisMap().Configure);
            modelBuilder.Entity<EstadoEntity>(new EstadoMap().Configure);
            modelBuilder.Entity<MunicipioEntity>(new MunicipioMap().Configure);            
        }

    }
}
