using Application.IRepositories;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZooManagementWebApi.DTOs;

namespace ZooManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CageController : ControllerBase
    {
        private readonly ICageRepository _cageRepository;
        private readonly IMapper mapper;
        public CageController(ICageRepository cageRepository, IMapper mapper)
        {
            _cageRepository = cageRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetCages()
        {
            var response = new ApiResponse()
            {
                Success = true,
                Value = await _cageRepository.GetCagesAsync()
            };
            return Ok(response);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetCageById(int id)
        {
            var response = new ApiResponse()
            {
                Success = true,
                Value = await _cageRepository.GetCageByIdAsync(id)
            };
            return Ok(response);
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddCage(CageDto cageDto)
        {
            var cage = mapper.Map<Cage>(cageDto);
            _cageRepository.AddCageAsync(cage);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateCage(CageDto cageDto)
        {
            var cage = mapper.Map<Cage>(cageDto);
            _cageRepository.UpdateCageAsync(cage);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpDelete]
        public async Task<IActionResult> SoftDeleteCage(int id)
        {
            _cageRepository.SoftDeleteCageAsync(id);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
    }
}
