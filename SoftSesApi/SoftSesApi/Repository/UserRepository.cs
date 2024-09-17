using SoftSesApi.Abstracts;
using SoftSesApi.Data;
using SoftSesApi.Model.Admin;

namespace SoftSesApi.Repository;

public class UserRepository : BaseRepository<User>
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }
}