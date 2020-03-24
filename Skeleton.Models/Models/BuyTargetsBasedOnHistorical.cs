using System;
using System.Collections.Generic;

namespace Skeleton.Models
{
    public partial class BuyTargetsBasedOnHistorical
    {
        public double CurrentPrice { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public double? AveragePrice { get; set; }
        public int ProductId { get; set; }
    }
}
