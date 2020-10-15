using appCoreThree.BUL.ModelsDTO; 
using System;
using System.Collections.Generic;
using System.Text;

namespace appCoreThree.BUL.Interfaces
{
    public interface IMasterService
    {
        IEnumerable<MasterDTO> GetAll();
        void Add(MasterDTO masterDTO); 
        void Update(MasterDTO masterDTO);
        void Remove(int id);
        void Dispose();
    }
}
