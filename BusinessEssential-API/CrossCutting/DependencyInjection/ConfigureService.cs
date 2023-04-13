using Domain.Interfaces.Service;
using Domain.Interfaces.Service.Estado;
using Microsoft.Extensions.DependencyInjection;
using Service.Estado;
using Service.Pagamento;
using Service.Usuario;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUsersService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
            serviceCollection.AddTransient<IPaymentService, PaymentService>();
            serviceCollection.AddTransient<IPaisService, PaisService>();
            serviceCollection.AddTransient<IEstadoService, EstadoService>();
            serviceCollection.AddTransient<IMunicipioService, MunicipioService>();
        }
    }
}
