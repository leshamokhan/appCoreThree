using appCoreThree.BUL.ModelsDTO;
using appCoreThree.DAL.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace appCoreThree.BUL.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Master,MasterDTO>()
                .ReverseMap();
            CreateMap<Region, RegionDTO>()
                .ReverseMap();

            CreateMap<MasterRegion, MasterRegionDTO>()
                .ReverseMap();
        }
    }
}
