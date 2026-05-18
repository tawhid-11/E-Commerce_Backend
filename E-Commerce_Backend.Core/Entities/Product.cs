using System;

namespace E_Commerce_Backend.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
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
