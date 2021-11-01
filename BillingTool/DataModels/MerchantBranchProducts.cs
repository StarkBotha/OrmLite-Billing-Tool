using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels
{
    public class MerchantBranchProducts
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid MerchantBranchId { get; set; }
        public string MerchantBranchProductNumber { get; set; }
        

        public override string ToString()
        {
            return MerchantBranchProductNumber;
        }
    }
}
