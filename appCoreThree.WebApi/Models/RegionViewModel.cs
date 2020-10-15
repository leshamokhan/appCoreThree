using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appCoreThree.WebApi.Models
{
    public class RegionViewModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class RegionViewModelID
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<MasterRegionViewModel> MasterRegions { get; set; }
    }

    public class RegionViewModelIDPut
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
