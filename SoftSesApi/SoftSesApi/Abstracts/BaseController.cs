using SoftSesApi.Data;
using SoftSesApi.Service;

namespace SoftSesApi.Abstracts;

public class BaseController<TService> where TService : class
{
    protected readonly TService _service;
    
    protected BaseController(TService service, HttpContext httpContext)
    {
        _service = service;
        HandleRequest(httpContext); ;
    }

    private Task<IResult> HandleRequest(HttpContext httpContext)
    {
        return HandleGet();
    }

    public async Task<IResult> HandleGet()
    {
        if (_service is not UserService userService) return Results.BadRequest("Service does not support GetAllUsers.");
        AppDbContext context;
        using (context = new AppDbContext())
        {
            return Results.BadRequest("OK foi");
        }
    }

    public IResult HandlePost()
    {
        return Results.Ok("Teste");
    }

    public IResult HandlePut()
    {
        return Results.Ok("Teste");
    }

    public IResult HandleDelete()
    {
        return Results.Ok("Teste");
    }
}