using Application.IRepositories;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZooManagementWebApi.DTOs;
using ZooManagementWebApi.Mapper;

namespace ZooManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalRepository _animalRepository;
        private readonly IMapper mapper;
        public AnimalController(IAnimalRepository animalRepository, IMapper mapper)
        {
            _animalRepository = animalRepository;
            this.mapper = mapper;
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
                Value = await _animalRepository.GetAnimalByIdAsync(id)
            };
            return Ok(response);
        }
        [HttpGet("diet")]
        public async Task<IActionResult> GetAnimalDietById(int id)
        {
            var response = new ApiResponse()
            {
                Success = true,
                Value = await _animalRepository.GetAnimalDietByIdAsync(id)
            };
            return Ok(response);
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddAnimals(AnimalInformationDto animalDto)
        {
            var animal = mapper.Map<AnimalInformation>(animalDto);
            _animalRepository.AddAnimalsAsync(animal);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateAnimal(AnimalInformationDto animalDto)
        {
            var animalInformation = mapper.Map<AnimalInformation>(animalDto);
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
