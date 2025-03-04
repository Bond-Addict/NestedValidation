using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using System.Runtime.CompilerServices;

namespace NestedValidation.UI
{
    public static class UI_Extentions
    {
        public static IServiceCollection Add_UI_Services(this IServiceCollection services)
        {
            services.AddMudServices();
            return services;
        }
    }
}
