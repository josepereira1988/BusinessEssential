using Domain.Entidades.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DATA.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasIndex(u => u.Usuario)
                   .IsUnique();
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
            builder.HasData(new UserEntity { ID = 1, Usuario = "Manager", Senha = Domain.Security.Criptografia.Criptografar("1234"), Email = "teste@teste.com.br", CreateAt = DateTime.Now, Ativo = true, Inativo = false, Departamento = 1, Nome = "adm" });
        }
    }
}
