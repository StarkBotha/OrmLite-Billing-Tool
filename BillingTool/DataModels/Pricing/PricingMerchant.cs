using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels.Pricing
{
    public class PricingMerchant : PricingBase
    {
        public Guid MerchantId { get; set; }
    }
}
