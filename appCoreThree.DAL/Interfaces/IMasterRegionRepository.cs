using appCoreThree.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace appCoreThree.DAL.Interfaces
{
    public interface IMasterRegionRepository 
    {
        void Add(MasterRegion masterRegion);
        void Remove(MasterRegion masterRegion);
    }
}
