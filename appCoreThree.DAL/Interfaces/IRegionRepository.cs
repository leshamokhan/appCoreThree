using appCoreThree.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace appCoreThree.DAL.Interfaces
{
    public interface IRegionRepository : IGenericRepository<Region>
    {
        IEnumerable<Region> GetAll(); 
    }
}
