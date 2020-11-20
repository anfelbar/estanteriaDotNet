using System;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Components.Forms;
// implements IDisposable

namespace Estanteria.Data
{
    public class ProductVM
    {
        public int Id { get; set; }

        [Required]
        [StringLength(16, ErrorMessage = "Name too long (16 max).")]
        public string Name { get; set; }

        [Range(0, Int32.MaxValue, ErrorMessage = "Prices are always positive.")]
        public int Price { get; set; }

        [Range(0, Int32.MaxValue, ErrorMessage = "Stock is always positive.")]
        public int Stock { get; set; }

        //[Required(ErrorMessage = "Please choose product image")]  
        [FileValidation(new[] { ".png", ".jpg" })]
        public IBrowserFile Picture { get; set; } 
    }

    class FileValidationAttribute : ValidationAttribute
    {
        public FileValidationAttribute(string[] allowedExtensions)
        {
            AllowedExtensions = allowedExtensions;
        }

        private string[] AllowedExtensions { get; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var file = (IBrowserFile)value;

            var extension = System.IO.Path.GetExtension(file.Name);

            if (!AllowedExtensions.Contains(extension, StringComparer.OrdinalIgnoreCase))
            {
                return new ValidationResult($"File must have one of the following extensions: {string.Join(", ", AllowedExtensions)}.", new[] { validationContext.MemberName });
            }

            return ValidationResult.Success;
        }
    }
}