using Application.IRepositories;
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
        public ActionResult<IQueryable<Cage>> Get()
        {
            IQueryable<Cage> cages;
            try
            {
                cages = _cageRepository.GetCagesAsync(); //roi chinh lai het y chang v di
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(cages); // khong tolist lun
        }
        [HttpGet]
        public ActionResult<SingleResult> Get([FromRoute] int key)
        {
            var cage =  _cageRepository.GetCageByIdAsync(key);

            if (cage == null)
            {
                return NotFound();
            }
            return Ok(new SingleResult<Cage>(cage));
        }
        [HttpPost]
        [Authorize(Roles = "Staff,Admin")]
        public async Task<ActionResult<Cage>> Post([FromBody] CageDto dto)
        {
            Cage cage;
            try
            {
                cage = mapper.Map<Cage>(dto);
                await _cageRepository.AddCageAsync(cage);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return CreatedAtAction("Get", new { key = cage.Id }, cage);
        }
        [HttpPut]
        [Authorize(Roles = "Staff,Admin")]
        public async Task<IActionResult> Put([FromRoute] int key, [FromBody] CageDto dto)
        {
            try
            {
                var cage = mapper.Map<Cage>(dto);
                cage.Id = key;
                await _cageRepository.UpdateCageAsync(cage);
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
        [Authorize(Roles = "Staff,Admin")]
        public async Task<IActionResult> Delete([FromRoute] int key)
        {
            try
            {
                await _cageRepository.SoftDeleteCageAsync(key);
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
