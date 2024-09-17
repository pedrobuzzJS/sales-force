using SoftSesApi.Model;

namespace SoftSesApi.Interface;

public interface IUserService
{
    List<User> GetAllUsers();
}