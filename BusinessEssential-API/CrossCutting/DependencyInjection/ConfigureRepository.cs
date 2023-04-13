using Api.Data.Repository;
using DATA.Context;
using DATA.Repository;
using Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            try
            {
                serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
                serviceCollection.AddScoped(typeof(IATRepository<>), typeof(ATRepository<>));
                serviceCollection.AddScoped<ILoginRepository, LoginRepository>();
                serviceCollection.AddScoped<IPaymentRepository, PaymentRepository>();               
                serviceCollection.AddDbContext<MyContext>(
                    options => options.UseMySQL(DATA.DBInforme.connectionString())
                );

            }
            catch (Exception ex)
            {

                //throw;
            }

        }
    }
}
