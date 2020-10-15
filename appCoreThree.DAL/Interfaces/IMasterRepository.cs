using appCoreThree.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace appCoreThree.DAL.Interfaces
{
    public interface IMasterRepository : IGenericRepository<Master>
    {
        IEnumerable<Master> GetAll(); 
    }
}
