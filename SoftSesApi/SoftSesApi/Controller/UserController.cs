using SoftSesApi.Abstracts;
using SoftSesApi.Service;

namespace SoftSesApi.Controller;

public class UserController : BaseController<UserService>
{
    public UserController(UserService service, HttpContext httpContext) : base(service, httpContext)
    {
    }
}