using System;
using System.Collections.Generic;

namespace Skeleton.Models
{
    public partial class Buildings
    {
        public Buildings()
        {
            ProductManufacturing = new HashSet<ProductManufacturing>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Wages { get; set; }
        public DateTime? ModifedDate { get; set; }

        public virtual ICollection<ProductManufacturing> ProductManufacturing { get; set; }
    }
}
