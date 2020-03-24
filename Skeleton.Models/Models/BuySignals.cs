using System;
using System.Collections.Generic;

namespace Skeleton.Models
{
    public partial class BuySignals
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public double PercentDiscount { get; set; }
    }
}
