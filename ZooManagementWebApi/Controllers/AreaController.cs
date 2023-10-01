using Application.IRepositories;
using Application.Repositories;
using AutoMapper;
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
        private readonly IMapper mapper;
        public AreaController(IAreaRepository areaRepository, IMapper mapper)
        {
            _areaRepository = areaRepository;
            this.mapper = mapper;
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
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAreaById(int id)
        {
            var response = new ApiResponse()
            {
                Success = true,
                Value = await _areaRepository.GetAreaByIdAsync(id)
            };
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> AddArea(AreaDto areaDto)
        {
            var area = mapper.Map<Area>(areaDto);
            await _areaRepository.AddAreaAsync(area);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateArea(int id, AreaDto areaDto)
        {
            var area = mapper.Map<Area>(areaDto);
            await _areaRepository.UpdateAreaAsync(id, area);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> SoftDeleteArea(int id)
        {
            await _areaRepository.SoftDeleteAreaAsync(id);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
    }
}
