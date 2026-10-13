
using FarmConnect.Api.Models;

namespace FarmConnect.Api.Services;

public interface IProductService
{
    //IReadOnlyList<Product> GetAll(string? searchTerm);
    Task<IReadOnlyList<Product>> GetAllAsync(string? searchTerm);

    //Product? GetById(int id);
    Task<Product?> GetByIdAsync(int id);

    //Product Add(Product product);
    Task<Product> AddAsync(Product product);
}
