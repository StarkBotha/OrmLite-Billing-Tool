using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels
{
    public class BillableResponseCodes
    {
        public Guid Id { get; set; }
        public Guid BillingCategoryId { get; set; }
        public string ResponseCode { get; set; }
        public string Description { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsFailed { get; set; }
        public bool IsDispute { get; set; }
        public bool IsCancelled { get; set; }
        public bool IsTracking { get; set; }
    }
}
