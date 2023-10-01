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
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDietById(int id)
        {
            var response = new ApiResponse()
            {
                Success = true,
                Value = await _dietRepository.GetDietByIdAsync(id)
            };
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> AddDiet(DietDto dietDto)
        {
            var diet = mapper.Map<Diet>(dietDto);
            await _dietRepository.AddDietAsync(diet);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDiet(int id, DietDto dietDto)
        {
            var diet = mapper.Map<Diet>(dietDto);
            await _dietRepository.UpdateDietAsync(id, diet);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> SoftDeleteDiet(int id)
        {
            await _dietRepository.SoftDeleteDietAsync(id);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
    }
}
