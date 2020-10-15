using appCoreThree.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using appCoreThree.DAL.Interfaces;
using appCoreThree.DAL.EF;
using appCoreThree.DAL.Repositories;
using appCoreThree.DAL.UnitOfWork;


namespace appCoreThree.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Masters = new MasterRepository(_context);
            Regions = new RegionRepository(_context);
            MasterRegions = new MasterRegionRepository(_context);
        }
        public IMasterRepository Masters { get; private set; }
        public IRegionRepository Regions { get; private set; }
        public IMasterRegionRepository MasterRegions { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
