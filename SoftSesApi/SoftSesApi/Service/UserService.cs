using Microsoft.EntityFrameworkCore;
using SoftSesApi.Data;
using SoftSesApi.Model.Admin;
using SoftSesApi.Repository;

namespace SoftSesApi.Service;

public class UserService
{
    private readonly UserRepository _userRepository;

    public UserService(AppDbContext context)
    {
        _userRepository = new UserRepository(context);
    }

    public async Task<List<User>> GetAllUsers()
    {
        return await _userRepository.GetContext().ToListAsync();
    }
}