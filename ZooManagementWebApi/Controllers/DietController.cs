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
    public class DietController : ControllerBase
    {
        private readonly IDietRepository _dietRepository;
        private readonly IMapper mapper;
        public DietController(IDietRepository dietRepository, IMapper mapper)
        {
            _dietRepository = dietRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetDiets()
        {
            var response = new ApiResponse()
            {
                Success = true,
                Value = await _dietRepository.GetDietsAsync()
            };
            return Ok(response);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetDietById(int id)
        {
            var response = new ApiResponse()
            {
                Success = true,
                Value = await _dietRepository.GetDietByIdAsync(id)
            };
            return Ok(response);
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddDiet(DietDto dietDto)
        {
            var diet = mapper.Map<Diet>(dietDto);
            _dietRepository.AddDietAsync(diet);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateDiet(DietDto dietDto)
        {
            var diet = mapper.Map<Diet>(dietDto);
            _dietRepository.UpdateDietAsync(diet);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpDelete]
        public async Task<IActionResult> SoftDeleteDiet(int id)
        {
            _dietRepository.SoftDeleteDietAsync(id);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
    }
}
