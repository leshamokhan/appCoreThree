using appCoreThree.BUL.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace appCoreThree.BUL.Interfaces
{
    public interface IRegionService
    {
        IEnumerable<RegionDTO> GetAll();
        void Add(RegionDTO regionDTO);
        void Update(RegionDTO regionDTO);
        void Remove(int id);
        void Dispose();
    }
}
