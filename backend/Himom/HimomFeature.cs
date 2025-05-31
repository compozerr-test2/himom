using Core.Feature;
using Microsoft.Extensions.DependencyInjection;
using Himom.Services;

namespace Himom;

public class HimomFeature : IFeature
{

    void IFeature.ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IHimomService, HimomService>();
    }
}