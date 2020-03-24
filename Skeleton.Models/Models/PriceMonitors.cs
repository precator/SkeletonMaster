using System;
using System.Collections.Generic;

namespace Skeleton.Models
{
    public partial class PriceMonitors
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public double? PriceLowerThan { get; set; }
    }
}
