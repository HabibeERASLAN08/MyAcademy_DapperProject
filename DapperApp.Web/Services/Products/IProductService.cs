using DapperApp.Web.DTOs.Categories;
using DapperApp.Web.DTOs.Products;

namespace DapperApp.Web.Services.Products
{
    public interface IProductService
    {
        Task<IEnumerable<ResultProductDto>> GetAllAsync();
        Task<UpdateProductDto> GetByIdAsync(int id);

        Task CreateAsync(CreateProductDto productDto);
        Task UpdateAsync(UpdateProductDto productDto);

        Task DeleteAsync(int id);
    }
}
