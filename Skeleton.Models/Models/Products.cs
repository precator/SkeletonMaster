using System;
using System.Collections.Generic;

namespace Skeleton.Models
{
    public partial class Products
    {
        public Products()
        {
            Prices = new HashSet<Prices>();
        }

        public string Name { get; set; }
        public int ProductId { get; set; }
        public double? AvgPrice { get; set; }
        public double? HighPrice { get; set; }
        public double? LowPrice { get; set; }
        public bool EnableAlerts { get; set; }

        public virtual ICollection<Prices> Prices { get; set; }
    }
}
