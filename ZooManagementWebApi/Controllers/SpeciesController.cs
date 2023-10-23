using Application.IRepositories;
using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using ZooManagementWebApi.DTOs;

namespace ZooManagementWebApi.Controllers
{
    [EnableQuery]
    [Authorize]
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
        public ActionResult<IQueryable<Species>> Get()
        {
            IQueryable<Species> species;
            try
            {
                species = _speciesRepo.GetSpeciesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(species);
        }
        [HttpGet]
        public ActionResult<SingleResult> Get([FromRoute] int key)
        {
            var specie = _speciesRepo.GetSpeciesByIdAsync(key);

            if (specie == null)
            {
                return NotFound();
            }

            return Ok(new SingleResult<Species>(specie));
        }
        [HttpPost]
        [Authorize(Roles = "Staff")]
        public async Task<ActionResult<Species>> Post([FromBody] SpeciesDto dto)
        {
            Species species;
            try
            {
                species = mapper.Map<Species>(dto);
                await _speciesRepo.AddSpeciesAsync(species);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return CreatedAtAction("Get", new { key = species.Id }, species);
        }
        [HttpPut]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> Put([FromRoute] int key, [FromBody] SpeciesDto dto)
        {
            try
            {
                var species = mapper.Map<Species>(dto);
                species.Id = key;
                await _speciesRepo.UpdateSpeciesAsync(species);
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
                await _speciesRepo.SoftDeleteSpeciesAsync(key);
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
