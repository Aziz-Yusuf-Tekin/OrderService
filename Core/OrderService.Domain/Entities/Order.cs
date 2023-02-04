using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Domain.Entities
{
    public class Order : BaseEntity
    {
        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }

        [ForeignKey("CustomerId")]
        public Guid CustomerId { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}
