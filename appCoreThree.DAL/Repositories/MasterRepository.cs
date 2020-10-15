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
    public class MasterRepository : GenericRepository<Master>, IMasterRepository
    {
        public MasterRepository(ApplicationContext context) : base(context)
        {
        }

        public IEnumerable<Master> GetAll()
        {
            return _context.Masters.ToList();
        }
    }
}
