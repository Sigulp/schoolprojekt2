﻿using SchoolProjekt.BE.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        public async Task<List<ProductDto>> GetProduct2s()
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
