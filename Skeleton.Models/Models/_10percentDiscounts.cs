using System;
using System.Collections.Generic;

namespace Skeleton.Models
{
    public partial class _10percentDiscounts
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public double? AvgPrice { get; set; }
        public double? HighPrice { get; set; }
        public double? LowPrice { get; set; }
    }
}
