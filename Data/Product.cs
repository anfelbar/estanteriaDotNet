using System;
using System.ComponentModel.DataAnnotations;

namespace Estanteria.Data
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(16, ErrorMessage = "Name too long (16 max).")]
        public string Name { get; set; }

        [Range(0, Int32.MaxValue, ErrorMessage = "Prices are always positive.")]
        public int Price { get; set; }

        [Range(0, Int32.MaxValue, ErrorMessage = "Stock is always positive.")]
        public int Stock { get; set; }
    }
}