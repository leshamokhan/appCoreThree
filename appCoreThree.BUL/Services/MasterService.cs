using appCoreThree.BUL.Interfaces;
using appCoreThree.BUL.ModelsDTO;
using appCoreThree.DAL.Interfaces;
using appCoreThree.DAL.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace appCoreThree.BUL.Services
{
    public class MasterService : IMasterService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MasterService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<MasterDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<MasterDTO>>(_unitOfWork.Masters.GetAll());
        }                

        public void Add(MasterDTO masterDTO)
        {
            Master master = _mapper.Map<Master>(masterDTO);
             
            _unitOfWork.Masters.Add(master);
            _unitOfWork.Complete();    
        }        

        public void Update(MasterDTO masterDTO)
        {
            Master master = _mapper.Map<Master>(masterDTO);

            _unitOfWork.Masters.Update(master);
            _unitOfWork.Complete();           
        }

        public void Remove(int id)
        {
            Master master = _unitOfWork.Masters.GetById(id); 

            _unitOfWork.Masters.Remove(master);
            _unitOfWork.Complete();             
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
