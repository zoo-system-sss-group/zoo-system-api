using Application.IRepositories;
using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using System.Xml;
using ZooManagementWebApi.DTOs;

namespace ZooManagementWebApi.Controllers;

[EnableQuery]
public class AnimalsController : ControllerBase
{
    private readonly IAnimalRepository _animalRepository;
    private readonly IMapper mapper;
    public AnimalsController(IAnimalRepository animalRepository, IMapper mapper)
    {
        _animalRepository = animalRepository;
        this.mapper = mapper;
    }

    [HttpGet]
    public ActionResult<IQueryable<AnimalInformation>> Get()
    {
        IQueryable<AnimalInformation> animals;
        try
        {
            animals = _animalRepository.GetAnimalsAsync();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
        return Ok(animals);
    }


    [HttpGet]
    public ActionResult<SingleResult> Get([FromRoute] int key)
    {
        var animal = _animalRepository.GetAnimalByIdAsync(key);

        if (animal == null)
        {
            return NotFound();
        }

        return Ok(new SingleResult<AnimalInformation>(animal));
    }

    [HttpPost]
    [Authorize(Roles = "Staff,Admin")]
    public async Task<ActionResult<AnimalInformation>> Post([FromBody] AnimalInformationDto dto)
    {
        AnimalInformation animal;
        try
        {
            animal = mapper.Map<AnimalInformation>(dto);
            animal.CageHistories.Add(mapper.Map<CageHistory>(dto.CageHistory));
            await _animalRepository.AddAnimalsAsync(animal);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return CreatedAtAction("Get", new { key = animal.Id }, animal);
    }

    [HttpPut]
    [Authorize(Roles = "Staff,Admin")]
    public async Task<IActionResult> Put([FromRoute] int key, [FromBody] AnimalInformationDto dto)
    {
        try
        {
            var animal = mapper.Map<AnimalInformation>(dto);
            animal.Id = key;
            await _animalRepository.UpdateAnimalAsync(animal);
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
            await _animalRepository.SoftDeleteAnimalsAsync(key);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return NoContent();
    }
}
