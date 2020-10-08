using System;
using System.Linq;
using System.Threading.Tasks;

namespace Estanteria.Data
{
    public class ListillaService 
    {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<Product[]> GetForecastAsync(DateTime startDate)
        {
            
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Product
            {
                Name = Summaries[index],
                Price = rng.Next(-20, 55),
                Stock = rng.Next(-20, 55),
                
            }).ToArray());
        }
    }
}
