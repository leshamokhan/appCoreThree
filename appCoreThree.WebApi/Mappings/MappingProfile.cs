using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using appCoreThree.BUL.ModelsDTO;
using appCoreThree.WebApi.Models;

namespace appCoreThree.WebApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MasterDTO,MasterViewModel>()
                .ReverseMap(); 
            CreateMap<MasterDTO, MasterViewModelID>()
                .ReverseMap();


            CreateMap<RegionDTO, RegionViewModel>()
                .ReverseMap();
            CreateMap<RegionDTO, RegionViewModelID>()
                .ReverseMap();

            CreateMap<RegionDTO, RegionViewModelIDPut>()
                .ReverseMap();


            CreateMap<MasterRegionDTO, MasterRegionViewModel>()
                .ReverseMap(); 
            CreateMap<MasterRegionDTO, MasterRegionViewModelID>()
                 .ReverseMap();
        }
    }
}
