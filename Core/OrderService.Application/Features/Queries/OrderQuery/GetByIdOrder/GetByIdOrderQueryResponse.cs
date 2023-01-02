using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Queries.OrderQuery.GetByIdOrder
{
    public class GetByIdOrderQueryResponse
    {
        public Guid ProductId { get; set; }
        public Guid CustomerId { get; set; }
        public bool ApprovalStatus { get; set; }
        public TimeSpan OrderTime { get; set; }
    }
}
