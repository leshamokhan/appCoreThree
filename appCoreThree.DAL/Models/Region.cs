using System;
using System.Collections.Generic;
using System.Text;

namespace appCoreThree.DAL.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection <MasterRegion> MasterRegions { get; set; }

        //public ICollection<Master> Master { get; set; }
        //public Plot()
        //{
        //    Master = new List<Master>();
        //} 
    }
}
