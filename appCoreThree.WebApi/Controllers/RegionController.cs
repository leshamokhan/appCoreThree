using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 
using AutoMapper;
using appCoreThree.BUL.Interfaces;
using appCoreThree.WebApi.Models;
using appCoreThree.BUL.ModelsDTO;

namespace appCoreThree.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRegionService _regionService;

        public RegionController(IRegionService regionService, IMapper mapper)
        {
            _regionService = regionService;
            _mapper = mapper;
        }

        // GET: api/Region
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegionViewModelID>>> GetRegions()
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<RegionViewModelID>>(_regionService.GetAll()));
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // PUT: api/Region/5
        [HttpPut]
        public async Task<ActionResult> PutRegion(RegionViewModelIDPut regionViewModelIDPut)
        {
            try
            {
                RegionDTO regionDTO = _mapper.Map<RegionDTO>(regionViewModelIDPut);

                _regionService.Update(regionDTO);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // POST: api/Region
        [HttpPost]
        public async Task<ActionResult> PostRegion(RegionViewModel regionViewModel)
        {
            try
            {
                RegionDTO regionDTO = _mapper.Map<RegionDTO>(regionViewModel);
                
                _regionService.Add(regionDTO);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE: api/Region/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteRegion(int id)
        {
            try
            {
                _regionService.Remove(id);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
