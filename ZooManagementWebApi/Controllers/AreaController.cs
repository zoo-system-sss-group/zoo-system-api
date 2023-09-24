using Application.IRepositories;
using Application.Repositories;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZooManagementWebApi.DTOs;

namespace ZooManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        private readonly IAreaRepository _areaRepository;
        public AreaController(IAreaRepository areaRepository)
        {
            _areaRepository = areaRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAreas()
        {
            var response = new ApiResponse()
            {
                Success = true,
                Value = await _areaRepository.GetAreasAsync()
            };
            return Ok(response);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetAreaById(int id)
        {
            var response = new ApiResponse()
            {
                Success = true,
                Value = await _areaRepository.GetAreaByIdAsync(id)
            };
            return Ok(response);
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddArea(Area area)
        {
            _areaRepository.AddAreaAsync(area);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateArea(Area area)
        {
            _areaRepository.UpdateAreaAsync(area);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpDelete]
        public async Task<IActionResult> SoftDeleteArea(int id)
        {
            _areaRepository.SoftDeleteAreaAsync(id);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
    }
}
