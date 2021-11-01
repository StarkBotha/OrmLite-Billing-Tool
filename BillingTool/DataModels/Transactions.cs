using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels
{
    public class Transactions
    {
        public Guid Id { get; set; }
        [References(typeof(MerchantBranchProducts))]
        public Guid MerchantBranchProductId { get; set; }
        [References(typeof(PaymentService))]
        public Guid ChosenPaymentServiceId { get; set; }
        public DateTime UpdateTimestamp { get; set; }
        public long TotalCostInCents { get; set; }
    }
}
