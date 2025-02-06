using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretCore.Entities
{
    public class Brands : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Descripton { get; set; }
        public string? Logo { get; set; }
        public bool IsActive { get; set; }
        public int OrderNo { get; set; }
        public DateTime CreateDate { get; set; }
        public List<Product>? Products { get; set; }
    }
}
