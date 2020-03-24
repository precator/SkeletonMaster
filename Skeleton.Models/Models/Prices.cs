using System;
using System.Collections.Generic;

namespace Skeleton.Models
{
    public partial class Prices
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }

        public virtual Products Product { get; set; }
    }
}
