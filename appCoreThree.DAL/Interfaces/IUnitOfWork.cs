using System;
using System.Collections.Generic;
using System.Text;

namespace appCoreThree.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IMasterRepository Masters { get; }
        IRegionRepository Regions { get; }
        IMasterRegionRepository MasterRegions { get; }
        int Complete();
    }
}
