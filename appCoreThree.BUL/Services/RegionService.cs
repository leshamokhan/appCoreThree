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
    public class RegionService : IRegionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RegionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<RegionDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<RegionDTO>>(_unitOfWork.Regions.GetAll());
        }

        public void Add(RegionDTO regionDTO)
        {
            Region region = _mapper.Map<Region>(regionDTO);

            _unitOfWork.Regions.Add(region);
            _unitOfWork.Complete();
        }

        public void Update(RegionDTO regionDTO)
        {
            Region region = _mapper.Map<Region>(regionDTO);

            _unitOfWork.Regions.Update(region);
            _unitOfWork.Complete();
        }

        public void Remove(int id)
        {
            Region region = _unitOfWork.Regions.GetById(id);

            _unitOfWork.Regions.Remove(region);
            _unitOfWork.Complete();
        }
        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
