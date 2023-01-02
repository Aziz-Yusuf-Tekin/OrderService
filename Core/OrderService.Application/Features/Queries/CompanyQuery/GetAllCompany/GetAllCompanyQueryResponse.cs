﻿using OrderService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application.Features.Queries.CompanyQuery.GetAllCompany
{
    public class GetAllCompanyQueryResponse
    {
        public List<Company> companies { get; set; }
    }
}
