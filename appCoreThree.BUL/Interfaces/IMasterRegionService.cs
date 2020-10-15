using appCoreThree.BUL.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace appCoreThree.BUL.Interfaces
{
    public interface IMasterRegionService
    {
        void Add(MasterRegionDTO masterRegionDTO);
        void Remove(MasterRegionDTO masterRegionDTO);
        void Dispose();
    }
}
