using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels
{
    public class Products
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; internal set; }

        public override string ToString()
        {
            //return base.ToString();
            return Description;
        }
    }
}
