using System;
using System.Collections.Generic;

namespace Skeleton.Models
{
    public partial class ManufacturingProductsCosts
    {
        public string Productname { get; set; }
        public string Producedat { get; set; }
        public int InputOneId { get; set; }
        public int InputOneQty { get; set; }
        public int? InputTwoId { get; set; }
        public int? InputTwoQty { get; set; }
        public int? InputThreeId { get; set; }
        public int? InputThreeQty { get; set; }
        public int? InputFourId { get; set; }
        public int? InputFourQty { get; set; }
        public int? InputFiveId { get; set; }
        public int? InputFiveQty { get; set; }
        public double? UnitsPerHour { get; set; }
        public double? RetailPrice { get; set; }
        public int? Expr1 { get; set; }
        public double Buildingwages { get; set; }
    }
}
