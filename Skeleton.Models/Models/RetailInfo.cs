using System;
using System.Collections.Generic;

namespace Skeleton.Models
{
    public partial class RetailInfo
    {
        public int Id { get; set; }
        public double RetailPrice { get; set; }
        public double UnitsSoldPerHour { get; set; }
        public DateTime? Date { get; set; }
        public int? ProductId { get; set; }
    }
}
