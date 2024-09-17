using Microsoft.EntityFrameworkCore;
using SoftSesApi.Data;
using SoftSesApi.Model.System;
using SoftSesApi.Repository;

namespace SoftSesApi.Service;

public class MenuService
{
    private readonly MenuRepository _menuRepository;
    
    public MenuService(AppDbContext context)
    {
        _menuRepository = new MenuRepository(context);
    }

    public async Task<List<Menu>> ListMenusAsync()
    {
        return await _menuRepository.GetContext().ToListAsync();
    }
}