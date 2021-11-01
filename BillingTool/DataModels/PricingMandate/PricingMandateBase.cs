using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels.PricingMandate
{
    public class PricingMandateBase
    {
        public Guid Id { get; set; }
        public Guid PaymentServiceId { get; set; }
        public Guid MandatePricingType { get; set; }
        public Guid CostPerSuccess { get; set; }
        public Guid CostPerFailure { get; set; }
        public Guid CostPerCancellation { get; set; }
        public Guid CostPerAmendmentSuccess { get; set; }
        public Guid CostPerAmendmentFail { get; set; }
        public Guid CostPerAmendmentNotifyFail { get; set; }
        public int StartYear { get; set; }
        public int StartMonth { get; set; }
    }
}
