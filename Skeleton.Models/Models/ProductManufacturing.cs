using System;
using System.Collections.Generic;

namespace Skeleton.Models
{
    public partial class ProductManufacturing
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int InputOneId { get; set; }
        public double InputOneQty { get; set; }
        public int? InputTwoId { get; set; }
        public double? InputTwoQty { get; set; }
        public int? InputThreeId { get; set; }
        public double? InputThreeQty { get; set; }
        public int? InputFourId { get; set; }
        public double? InputFourQty { get; set; }
        public int? InputFiveId { get; set; }
        public double? InputFiveQty { get; set; }
        public double? UnitsPerHour { get; set; }
        public double? RetailPrice { get; set; }
        public int ProducedAt { get; set; }
        public DateTime Date { get; set; }

        public virtual Buildings ProducedAtNavigation { get; set; }
    }
}
