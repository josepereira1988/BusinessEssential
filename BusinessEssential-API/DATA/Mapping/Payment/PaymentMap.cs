using Domain.Entidades.Pagamento;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DATA.Mapping.Payment
{
    class PaymentMap : IEntityTypeConfiguration<PaymentEntity>
    {
        public void Configure(EntityTypeBuilder<PaymentEntity> builder)
        {
            builder.HasIndex(u => u.descricao).IsUnique();
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
        }
        public void Configure(EntityTypeBuilder<PaymentLinhas> builder)
        {
            builder.HasKey(p => new { p.ID,p.Linha });
            //builder.Property(p => p.Linha).ValueGeneratedOnAdd();
            builder.HasOne(l => l.Payment).WithMany(l => l.PaymentLinhas).HasForeignKey(i => i.ID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
