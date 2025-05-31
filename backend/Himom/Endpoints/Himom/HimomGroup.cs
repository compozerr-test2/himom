using Carter;
using Microsoft.AspNetCore.Routing;

namespace Himom.Endpoints.Himom;

public class HimomGroup : CarterModule
{
    public HimomGroup() : base("/himom")
    {
        WithTags(nameof(Himom));
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.AddHimomRoute();
    }
}