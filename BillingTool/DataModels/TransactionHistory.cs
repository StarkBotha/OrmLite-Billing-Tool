using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels
{
    public class TransactionHistory
    {
        public Guid Id { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool? Billed { get; set; }
        public string OutcomeCode { get; set; }

        [References(typeof(Transactions))]
        public Guid TransactionId { get; set; }
        [References(typeof(MerchantBranchProducts))]
        public Guid MerchantBranchProductId { get; set; }
    }
}
