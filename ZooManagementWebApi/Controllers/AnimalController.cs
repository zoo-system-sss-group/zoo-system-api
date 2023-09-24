using Application.IRepositories;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZooManagementWebApi.DTOs;

namespace ZooManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalRepository _animalRepository;
        public AnimalController(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAnimals()
        {
            var response = new ApiResponse()
            {
                Success = true,
                Value = await _animalRepository.GetAnimalsAsync()
            };
            return Ok(response);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetAnimalsById(int id)
        {
            var response = new ApiResponse()
            {
                Success = true,
                Value = await _animalRepository.GetAnimalsByIdAsync(id)
            };
            return Ok(response);
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddAnimals(AnimalInformation animal)
        {
            _animalRepository.AddAnimalsAsync(animal);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateAnimal(AnimalInformation animalInformation)
        {
            _animalRepository.UpdateAnimalAsync(animalInformation);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpDelete]
        public async Task<IActionResult> SoftDeleteAnimals(int id)
        {
            _animalRepository.SoftDeleteAnimalsAsync(id);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
    }
}
