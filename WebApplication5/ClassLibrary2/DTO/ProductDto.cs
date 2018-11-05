using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProjekt.BE.DTO
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
