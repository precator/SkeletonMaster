using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.Models.ViewModels
{
    class SampleViewModel
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
