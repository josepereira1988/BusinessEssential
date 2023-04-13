using Domain.Entidades.Estado;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DATA.Mapping
{
    public class EstadoMap : IEntityTypeConfiguration<EstadoEntity>
    {
        public void Configure(EntityTypeBuilder<EstadoEntity> builder)
        {
            builder.HasData(new EstadoEntity { ID = 1, Nome = "Acre", IBGE = 12, IDPais = 1058, UF = "AC" });
            builder.HasData(new EstadoEntity { ID = 2, Nome = "Alagoas", IBGE = 27, IDPais = 1058, UF = "AL" });
            builder.HasData(new EstadoEntity { ID = 3, Nome = "Amapá", IBGE = 16, IDPais = 1058, UF = "AP" });
            builder.HasData(new EstadoEntity { ID = 4, Nome = "Amazonas", IBGE = 13, IDPais = 1058, UF = "AM" });
            builder.HasData(new EstadoEntity { ID = 5, Nome = "Bahia", IBGE = 29, IDPais = 1058, UF = "BA" });
            builder.HasData(new EstadoEntity { ID = 6, Nome = "Ceará", IBGE = 23, IDPais = 1058, UF = "CE" });
            builder.HasData(new EstadoEntity { ID = 7, Nome = "Distrito Federal", IBGE = 53, IDPais = 1058, UF = "DF" });
            builder.HasData(new EstadoEntity { ID = 8, Nome = "Espírito Santo", IBGE = 32, IDPais = 1058, UF = "ES" });
            builder.HasData(new EstadoEntity { ID = 9, Nome = "Goiás", IBGE = 52, IDPais = 1058, UF = "GO" });
            builder.HasData(new EstadoEntity { ID = 10, Nome = "Maranhão", IBGE = 21, IDPais = 1058, UF = "MA" });
            builder.HasData(new EstadoEntity { ID = 11, Nome = "Mato Grosso", IBGE = 51, IDPais = 1058, UF = "MT" });
            builder.HasData(new EstadoEntity { ID = 12, Nome = "Mato Grosso do Sul", IBGE = 50, IDPais = 1058, UF = "MS" });
            builder.HasData(new EstadoEntity { ID = 13, Nome = "Minas Gerais", IBGE = 31, IDPais = 1058, UF = "MG" });
            builder.HasData(new EstadoEntity { ID = 14, Nome = "Pará", IBGE = 15, IDPais = 1058, UF = "PA" });
            builder.HasData(new EstadoEntity { ID = 15, Nome = "Paraíba", IBGE = 25, IDPais = 1058, UF = "PB" });
            builder.HasData(new EstadoEntity { ID = 16, Nome = "Paraná", IBGE = 41, IDPais = 1058, UF = "PR" });
            builder.HasData(new EstadoEntity { ID = 17, Nome = "Pernambuco", IBGE = 26, IDPais = 1058, UF = "PE" });
            builder.HasData(new EstadoEntity { ID = 18, Nome = "Piauí", IBGE = 22, IDPais = 1058, UF = "PI" });
            builder.HasData(new EstadoEntity { ID = 19, Nome = "Rio de Janeiro", IBGE = 33, IDPais = 1058, UF = "RJ" });
            builder.HasData(new EstadoEntity { ID = 20, Nome = "Rio Grande do Norte", IBGE = 24, IDPais = 1058, UF = "RN" });
            builder.HasData(new EstadoEntity { ID = 21, Nome = "Rio Grande do Sul", IBGE = 43, IDPais = 1058, UF = "RS" });
            builder.HasData(new EstadoEntity { ID = 22, Nome = "Rondônia", IBGE = 11, IDPais = 1058, UF = "RO" });
            builder.HasData(new EstadoEntity { ID = 23, Nome = "Roraima", IBGE = 14, IDPais = 1058, UF = "RR" });
            builder.HasData(new EstadoEntity { ID = 24, Nome = "Santa Catarina", IBGE = 42, IDPais = 1058, UF = "SC" });
            builder.HasData(new EstadoEntity { ID = 25, Nome = "São Paulo", IBGE = 35, IDPais = 1058, UF = "SP" });
            builder.HasData(new EstadoEntity { ID = 26, Nome = "Sergipe", IBGE = 28, IDPais = 1058, UF = "SE" });
            builder.HasData(new EstadoEntity { ID = 27, Nome = "Tocantins", IBGE = 17, IDPais = 1058, UF = "TO" });


        }
    }
}
