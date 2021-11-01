using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels
{
    public class Merchants
    {
        public Guid Id { get; set; }
        public string TradingAsName { get; set; }
        public bool IsApproved { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsRejected { get; set; }


        public override string ToString()
        {
            return TradingAsName;
        }
    }
}
