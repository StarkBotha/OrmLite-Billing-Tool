﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels.PricingMandate
{
    public class PricingMandateMerchant : PricingMandateBase
    {
        public Guid MerchantId { get; set; }
    }
}
