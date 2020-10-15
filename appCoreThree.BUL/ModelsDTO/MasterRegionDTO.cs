using System;
using System.Collections.Generic;
using System.Text;

namespace appCoreThree.BUL.ModelsDTO
{
    public class MasterRegionDTO
    {
        public int MasterId { get; set; }
        public virtual MasterDTO Master { get; set; }

        public int RegionId { get; set; }
        public virtual RegionDTO Region { get; set; }
    }
}
