using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingTool.DataModels.VolumeBreak
{
    public class VolumeBreakType
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int CorrelationId { get; set; }
    }
}
