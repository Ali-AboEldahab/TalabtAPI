﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flavorful.Core.Specifications.OrderSpecifications
{
    public class OrderWithPaymentIntentSpecs : BaseSpecifications<Order>
    {
        public OrderWithPaymentIntentSpecs(string paymentIntentId)
            : base(o => o.PaymentIntentId == paymentIntentId)
        {

        }
    }
}
