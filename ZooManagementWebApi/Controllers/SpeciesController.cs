using Application.Commons;
using Application.IRepositories;
using Application.IServices;
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
        public SpeciesController(ISpeciesRepository speciesRepo)
        {
            _speciesRepo = speciesRepo;
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
        [HttpGet("id")]
        public async Task<IActionResult> GetSpeciesById(int id)
        {
            var response = new ApiResponse()
            {
                Success = true,
                Value = await _speciesRepo.GetSpeciesByIdAsync(id)
            };
            return Ok(response);
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddSpecies(Species species)
        {
            _speciesRepo.AddSpeciesAsync(species);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
    }
}
