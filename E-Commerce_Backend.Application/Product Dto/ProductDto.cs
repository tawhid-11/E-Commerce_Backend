using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Backend.Application.Product_Dto
{
    public class ProductDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Size { get; set; } = null!;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateOnly MFG { get; set; }
        public DateOnly ExpireDate { get; set; }
        public int CategoryId { get; set; }
    }
}
