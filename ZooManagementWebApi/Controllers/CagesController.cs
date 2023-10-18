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
    public class CagesController : ControllerBase
    {
        private readonly ICageRepository _cageRepository;
        private readonly IDietRepository _dietRepository;
        private readonly IMapper mapper;
        public CagesController(ICageRepository cageRepository, IDietRepository dietRepository, IMapper mapper)
        {
            _cageRepository = cageRepository;
            _dietRepository = dietRepository;
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
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCageById(int id)
        {
            var cage = await _cageRepository.GetCageByIdAsync(id);
            var response = new ApiResponse()
            {
                Success = true,
                Value = cage
            };
            return Ok(response);
        }
        [HttpGet("{id}/diet")]
        public async Task<IActionResult> GetCageDietById(int id)
        {
            var cage = await _cageRepository.GetCageByIdAsync(id);
            var cageDto = mapper.Map<CageDto>(cage);
            foreach(CageHistory c in cage.CageHistories)
            {
                cageDto.Diets.Add(await _dietRepository.GetCurrentDietByAnimalIdAsync(c.AnimalId));
            }
            cageDto.OveralDiet = GetDiet(cageDto.Diets.ToList());
            cageDto.CageHistories.Clear();
            var response = new ApiResponse()
            {
                Success = true,
                Value = cageDto
            };
            return Ok(response);
        }
        private string GetDiet(List<Diet> diets)
        {
            List<double> listQuantity = new List<double>();
            List<string> listUnit = new List<string>();
            foreach(Diet diet in diets)
            {
                if (listUnit.Contains(diet.Unit + " " + diet.FoodName))
                {
                    int index = listUnit.IndexOf(diet.Unit);
                    listQuantity[index] += diet.Quantity;
                }
                else
                {
                    listUnit.Add(diet.Unit + " " + diet.FoodName);
                    listQuantity.Add(diet.Quantity);
                }
            }
            string result = "";
            if (listUnit != null)
            {
                for (int i = 0; i < listUnit.Count - 1; i++)
                {
                    result += listQuantity[i] + listUnit[i] + ", ";
                }
                result += listQuantity[listQuantity.Count-1] + listUnit[listUnit.Count-1] + ".";
                return result;
            }
            else
                return null;
        }
        [HttpPost]
        public async Task<IActionResult> AddCage(CageDto cageDto)
        {
            var cage = mapper.Map<Cage>(cageDto);
            await _cageRepository.AddCageAsync(cage);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCage(int id, CageDto cageDto)
        {
            var cage = mapper.Map<Cage>(cageDto);
            await _cageRepository.UpdateCageAsync(id, cage);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> SoftDeleteCage(int id)
        {
            await _cageRepository.SoftDeleteCageAsync(id);
            var response = new ApiResponse()
            {
                Success = true,
            };
            return Ok(response);
        }
    }
}
