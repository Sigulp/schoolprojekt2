using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolProjekt.FE.Models
{
    public class GoodViewModel
    {
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Display(Name = "szoveg")]
        public string szoveg { get; set; }
        
        [Display(Name = "szovegg")]
        public string szovegg { get; set; }

        [Display(Name = "Hometown")]
        public string Hometown { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}