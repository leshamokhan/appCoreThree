using appCoreThree.DAL.EF;
using appCoreThree.DAL.Interfaces;
using appCoreThree.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appCoreThree.DAL.Repositories
{
    public class RegionRepository : GenericRepository<Region>, IRegionRepository
    {
        public RegionRepository(ApplicationContext context) : base(context)
        {
        }

        public IEnumerable<Region> GetAll()
        {
            return _context.Regions
                .Include(p => p.MasterRegions)
                .ThenInclude(i => i.Master)
                .ToList();
        } 
    }
}
