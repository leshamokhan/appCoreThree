using appCoreThree.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using appCoreThree.DAL.Interfaces;
using appCoreThree.DAL.Repositories;
using appCoreThree.DAL.EF;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace appCoreThree.DAL.Repositories
{
    public class MasterRegionRepository : GenericRepository<MasterRepository>, IMasterRegionRepository
    {
        public MasterRegionRepository(ApplicationContext context) : base(context)
        {            
        }

        public void Add(MasterRegion masterRegion)
        {
            _context.MasterRegions.Add(masterRegion);
        }
        public void Remove(MasterRegion masterRegion)
        {
            _context.MasterRegions.Remove(masterRegion);
        }
    }
}