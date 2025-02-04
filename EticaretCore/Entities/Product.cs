using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretCore.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; } //ürünün fiyatı tutulacak alan
        public string? ProductCode { get; set; } //ürün kodu
        public int Stock { get; set; }
        public bool IsActive { get; set; }
        public bool IsHome { get; set; }
        public int? CategorytId { get; set; }
        public Category? Category { get; set; }
        public int? BrandId { get; set; }
        public Brands? Brand { get; set; }
        public int OrderNo { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
