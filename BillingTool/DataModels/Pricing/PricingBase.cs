using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels.Pricing
{
    public class PricingBase
    {
        public Guid Id { get; set; }
        public Guid PaymentServiceId { get; set; }
        public int CostPerSuccess { get; set; }
        public int CostPerFailure { get; set; }
        public int CostPerDispute { get; set; }
        public int CostPerTrackingDay { get; set; }
        public int StartYear { get; set; }
        public int StartMonth { get; set; }
    }
}
