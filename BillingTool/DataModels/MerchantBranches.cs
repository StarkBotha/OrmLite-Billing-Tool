using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels
{
    public class MerchantBranches
    {
        public Guid Id { get; set; }
        public string TradingName { get; set; }
        public Guid MerchantId { get; set; }

        public override string ToString()
        {
            return TradingName;
        }
    }
}
