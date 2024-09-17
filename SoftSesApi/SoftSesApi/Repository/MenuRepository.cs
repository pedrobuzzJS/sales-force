using SoftSesApi.Abstracts;
using SoftSesApi.Data;
using SoftSesApi.Model.System;

namespace SoftSesApi.Repository;

public class MenuRepository : BaseRepository<Menu>
{
    public MenuRepository(AppDbContext context) : base(context)
    {
    }
}