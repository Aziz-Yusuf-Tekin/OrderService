﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Queries.OrderQuery.GetAllOrder
{
    public class GettAllOrderQueryRequest : IRequest<GettAllOrderQueryResponse>
    {
    }
}
