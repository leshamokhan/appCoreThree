using System;
using System.Collections.Generic;
using System.Text;

namespace appCoreThree.BUL.ModelsDTO
{
    public class RegionDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<MasterRegionDTO> MasterRegions { get; set; }
    }
}
