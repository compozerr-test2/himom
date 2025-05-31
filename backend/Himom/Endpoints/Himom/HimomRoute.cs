using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Himom.Services;

namespace Himom.Endpoints.Himom;

public static class HimomRoute
{
    public static RouteHandlerBuilder AddHimomRoute(this IEndpointRouteBuilder app)
    {
        return app.MapGet("/", (string name, IHimomService himomService) => new GetHimomResponse($"Hello, {himomService.GetObfuscatedName(name)}!"));
    }
}