using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SchoolProjekt.BE.DTO;

namespace SchoolProjekt.BE.Services
{
    public class HomeService
    {
        public async Task<List<ProductDto>> GetProducts()
        {
            List<ProductDto> productList = new List<ProductDto>();
            ProductDto product = new ProductDto()
            {
                Id = 1,
                Category = "category",
                Name = "name",
                Price = 1
            };

            ProductDto product1 = new ProductDto()
            {
                Id = 1,
                Category = "category",
                Name = "name",
                Price = 1
            };
            productList.Add(product);
            productList.Add(product1);

            return productList;
        }
    }
}
