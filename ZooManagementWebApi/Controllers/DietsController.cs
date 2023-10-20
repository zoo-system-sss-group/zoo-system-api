using Application.IRepositories;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using ZooManagementWebApi.DTOs;

namespace ZooManagementWebApi.Controllers
{
    [EnableQuery]
    [Authorize]
    public class DietsController : ControllerBase
    {
        private readonly IDietRepository _dietRepository;
        private readonly IMapper mapper;
        public DietsController(IDietRepository dietRepository, IMapper mapper)
        {
            _dietRepository = dietRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Diet>>> Get()
        {
            List<Diet> diets;
            try
            {
                diets = await _dietRepository.GetDietsAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(diets);
        }
        [HttpGet]
        public async Task<ActionResult<Diet>> Get([FromRoute] int key)
        {
            var diet = await _dietRepository.GetDietByIdAsync(key);

            if (diet == null)
            {
                return NotFound();
            }

            return Ok(diet);
        }
        [HttpPost]
        [Authorize(Roles = "Staff")]
        public async Task<ActionResult<Diet>> Post([FromBody] DietDto dto)
        {
            Diet diet;
            try
            {
                diet = mapper.Map<Diet>(dto);
                await _dietRepository.AddDietAsync(diet);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return CreatedAtAction("Get", new { key = diet.Id }, diet);
        }
        [HttpPut]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> Put([FromRoute] int key, [FromBody] DietDto dto)
        {
            try
            {
                var diet = mapper.Map<Diet>(dto);
                diet.Id = key;
                await _dietRepository.UpdateDietAsync(diet);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NoContent();
        }

        [HttpDelete]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> Delete([FromRoute] int key)
        {
            try
            {
                await _dietRepository.SoftDeleteDietAsync(key);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return NoContent();
        }
    }
}
