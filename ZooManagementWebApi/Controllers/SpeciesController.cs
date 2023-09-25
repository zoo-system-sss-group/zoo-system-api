using Application.Commons;
using Application.IRepositories;
using Application.IServices;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZooManagementWebApi.DTOs;

namespace ZooManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeciesController : ControllerBase
    {
        private readonly ISpeciesRepository _speciesRepo;
        private readonly IMapper mapper;
        public SpeciesController(ISpeciesRepository speciesRepo, IMapper mapper)
        {
            _speciesRepo = speciesRepo;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetSpecies()
        {
            var response = new ApiResponse()
            {
                Success = true,
                Value = await _speciesRepo.GetSpeciesAsync()
            };
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpeciesById(int id)
        {
            var response = new ApiResponse()
            {
                Success = true,
                Value = await _speciesRepo.GetSpeciesByIdAsync(id)
            };
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> AddSpecies(SpeciesDto speciesDto)
        {
            var species = mapper.Map<Species>(speciesDto);
            _speciesRepo.AddSpeciesAsync(species);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSpecies(int id, SpeciesDto speciesDto)
        {
            var species = mapper.Map<Species>(speciesDto);
            _speciesRepo.UpdateSpeciesAsync(id, species);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> SoftDeleteSpecies(int id)
        {
            _speciesRepo.SoftDeleteSpeciesAsync(id);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
    }
}
