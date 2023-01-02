using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Domain.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public TimeSpan OrderStartTime { get; set; }
        public TimeSpan OrderEndTime { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
