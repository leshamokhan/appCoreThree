using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; 
using appCoreThree.BUL.Interfaces;
using appCoreThree.BUL.Services;
using appCoreThree.BUL.ModelsDTO;
using appCoreThree.WebApi.Models;
using AutoMapper;

namespace appCoreThree.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMasterService _masterService;

        public MasterController(IMasterService masterService, IMapper mapper)
        {
            _masterService = masterService;
            _mapper = mapper;
        }

        // GET: api/Master
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MasterViewModelID>>> GetMasters()
        { 
            try
            {
                return Ok(_mapper.Map<IEnumerable<MasterViewModelID>>(_masterService.GetAll()));
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // PUT: api/Master/5
        [HttpPut]
        public async Task<ActionResult> PutMaster(MasterViewModelID masterViewModelID)
        {
            try
            {
                MasterDTO masterDTO = _mapper.Map<MasterDTO>(masterViewModelID);

                _masterService.Update(masterDTO);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }            
        }

        // POST: api/Master
        [HttpPost]
        public async Task<ActionResult> PostMaster(MasterViewModel masterViewModel)
        {
            try
            {
                MasterDTO masterDTO = _mapper.Map<MasterDTO>(masterViewModel);                 

                _masterService.Add(masterDTO);
                return Ok();
            }
            catch 
            {
                return StatusCode(500);
            }
        }

        // DELETE: api/Master/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMaster(int id)
        {
            try
            {
                _masterService.Remove(id);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
