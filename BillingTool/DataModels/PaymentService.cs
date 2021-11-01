using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels
{
    public class PaymentService
    {
        public Guid Id { get; set; }
        public int CorrelationId { get; set; }
        public string Description { get; set; }
    }
}
