using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appCoreThree.WebApi.Models
{
    public class MasterRegionViewModel
    {
        public virtual MasterViewModelID Master { get; set; }
    }

    public class MasterRegionViewModelID
    {
        public int MasterId { get; set; }
        public int RegionId { get; set; }
    }
}
