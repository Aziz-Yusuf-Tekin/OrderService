﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Queries.CompanyQuery.GetByIdCompany
{
    public class GetByIdCompanyQueryResponse
    {
        public string Name { get; set; }
        public TimeSpan OrderStartTime { get; set; }
        public TimeSpan OrderEndTime { get; set; }
    }
}
