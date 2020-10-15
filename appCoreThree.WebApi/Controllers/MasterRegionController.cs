using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using appCoreThree.DAL.EF;
using appCoreThree.DAL.Models;
using AutoMapper;
using appCoreThree.BUL.Interfaces;
using appCoreThree.WebApi.Models;
using appCoreThree.BUL.ModelsDTO;

namespace appCoreThree.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterRegionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMasterRegionService _masterRegionService;

        public MasterRegionController(IMasterRegionService masterRegionService, IMapper mapper)
        {
            _masterRegionService = masterRegionService;
            _mapper = mapper;
        }

        // POST: api/MasterRegion
        [HttpPost]
        public async Task<ActionResult> PostMasterRegion(MasterRegionViewModelID masterRegionViewModelID)
        {
            try
            {
                MasterRegionDTO masterRegionDTO = _mapper.Map<MasterRegionDTO>(masterRegionViewModelID);

                _masterRegionService.Add(masterRegionDTO);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE: api/MasterRegion
        [HttpDelete]
        public async Task<ActionResult> DeleteMasterRegion(MasterRegionViewModelID masterRegionViewModelID)
        {
            try
            {
                MasterRegionDTO masterRegionDTO = _mapper.Map<MasterRegionDTO>(masterRegionViewModelID);

                _masterRegionService.Remove(masterRegionDTO);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
