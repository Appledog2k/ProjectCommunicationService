using Catalog.Service.Models;

namespace Catalog.Service.Services
{

    public static class Extensions
    {
        //* Trả về file DTO
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto(item.Id, item.Name, item.Description, item.Price, item.CreatedDate);
        }
    }
}

