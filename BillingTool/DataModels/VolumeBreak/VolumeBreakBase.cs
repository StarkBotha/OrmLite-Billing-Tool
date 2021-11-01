using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels.VolumeBreak
{
    public class VolumeBreakBase
    {
        public Guid Id { get; set; }
        public Guid VolumeBreakTypeId { get; set; }
        public int ApplicableVolume { get; set; }
        public Guid ServiceId { get; set; }        
        public int TransactionSuccess { get; set; }
        public int TransactionFailure { get; set; }
        public int TransactionDispute { get; set; }
        public int MandateSuccess { get; set; }
        public int MandateFailure { get; set; }
        public int MandateCancellation { get; set; }
        public int MandateAmendmentSuccess { get; set; }
        public int MandateAmendmentFail { get; set; }
        public int MandateAmendmentNotifyFail { get; set; }
        public Guid? MandatePricingTypeId { get; set; }
        public int StartYear { get; set; }
        public int StartMonth { get; set; }
        public decimal TransactionSuccessPerc { get; set; }
        public decimal TransactionFailurePerc { get; set; }
        public decimal TransactionDisputePerc { get; set; }
        public int CostPerTrackingDay { get; set; }
        public decimal CostPerTrackingDayPerc { get; set; }
    }
}
