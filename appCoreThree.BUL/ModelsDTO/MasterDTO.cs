using System;
using System.Collections.Generic;
using System.Text;

namespace appCoreThree.BUL.ModelsDTO
{
    public class MasterDTO
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public ICollection<MasterRegionDTO> MasterRegions { get; set; }
    }
}
