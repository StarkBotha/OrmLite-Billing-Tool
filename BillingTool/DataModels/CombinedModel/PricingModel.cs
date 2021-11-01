using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels.CombinedModel
{
    public class PricingModel
    {
        public Guid TransactionHistoryId { get; set; }
        public DateTime TransactionHistoryDate { get; set; }
    }
}
