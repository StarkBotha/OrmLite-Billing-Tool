﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels.PricingMandate
{
    public class PricingMandateBranch : PricingMandateBase
    {
        public Guid BranchId { get; set; }
    }
}
