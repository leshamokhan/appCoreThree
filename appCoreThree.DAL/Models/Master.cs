using System;
using System.Collections.Generic;
using System.Text;

namespace appCoreThree.DAL.Models
{
    public  class Master
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public ICollection<MasterRegion> MasterRegions { get; set;  }

        //public ICollection<Plot> Plot { get; set; }
        //public Master()
        //{
        //    Plot = new List<Plot>();
        //}
    }
}
