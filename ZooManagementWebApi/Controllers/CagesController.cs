﻿using Application.IRepositories;
using Application.Repositories;
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
        public async Task<ActionResult<IEnumerable<Cage>>> Get()
        {
            List<Cage> cages;
            try
            {
                cages = await _cageRepository.GetCagesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(cages);
        }
        [HttpGet]
        public async Task<ActionResult<Cage>> Get([FromRoute] int key)
        {
            var cage = await _cageRepository.GetCageByIdAsync(key);

            if (cage == null)
            {
                return NotFound();
            }
            return Ok(cage);
        }
        [HttpPost]
        [Authorize(Roles = "Staff")]
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
        [Authorize(Roles = "Staff")]
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
        [Authorize(Roles = "Staff")]
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
