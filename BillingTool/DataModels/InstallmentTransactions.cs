using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels
{
    public class InstallmentTransactions
    {
        public Guid Id { get; set; }
        [References(typeof(Installments))]
        public Guid InstallmentId { get; set; }
        [References(typeof(Transactions))]
        public Guid PaymentTransactionId { get; set; }

    }
}
