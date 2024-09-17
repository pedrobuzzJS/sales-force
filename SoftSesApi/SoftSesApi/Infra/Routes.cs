using SoftSesApi.Controller;
using SoftSesApi.Data;
using SoftSesApi.Model;
using SoftSesApi.Service;

namespace SoftSesApi.Infra;

public static class Routes
{
    public static void AddRoutes(this WebApplication app)
    {
        var group = app.MapGroup("/v1");
        group.MapGet("/user", (UserService service, HttpContext httpContext) => new UserController(service, httpContext));
    }
}