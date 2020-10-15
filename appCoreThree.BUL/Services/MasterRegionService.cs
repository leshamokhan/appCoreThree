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
    public class MasterRegionService: IMasterRegionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MasterRegionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }         

        public void Add(MasterRegionDTO masterRegionDTO)
        {
            MasterRegion masterRegion = _mapper.Map<MasterRegion>(masterRegionDTO);

            _unitOfWork.MasterRegions.Add(masterRegion);
            _unitOfWork.Complete();
        }
        public void Remove(MasterRegionDTO masterRegionDTO)
        {
            MasterRegion masterRegion = _mapper.Map<MasterRegion>(masterRegionDTO);

            _unitOfWork.MasterRegions.Remove(masterRegion);
            _unitOfWork.Complete();
        }                 

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
