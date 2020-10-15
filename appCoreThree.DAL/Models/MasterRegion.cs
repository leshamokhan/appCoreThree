using System;
using System.Collections.Generic;
using System.Text;

namespace appCoreThree.DAL.Models
{
    public class MasterRegion
    {
        public int MasterId { get; set; }
        public virtual Master Master { get; set; }

        public int RegionId { get; set; }
        public virtual Region Region { get; set; }
    }
}
