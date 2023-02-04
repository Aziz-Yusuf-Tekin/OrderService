using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Domain.Entities
{
    public class Product : BaseEntity
    {
        [ForeignKey("CompanyId")]
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }

        public ICollection<Order> Orders { get; set; }
        public virtual Company Company { get; set; }
    }
}
