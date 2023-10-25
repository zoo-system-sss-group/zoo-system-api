using Application.IRepositories;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using ZooManagementWebApi.DTOs;

namespace ZooManagementWebApi.Controllers;

[EnableQuery]
public class AreasController : ControllerBase
{
    private readonly IAreaRepository _areaRepository;
    private readonly IMapper mapper;
    public AreasController(IAreaRepository areaRepository, IMapper mapper)
    {
        _areaRepository = areaRepository;
        this.mapper = mapper;
    }
    [HttpGet]
    public ActionResult<IQueryable<Area>> Get()
    {
        IQueryable<Area> areas;
        try
        {
            areas = _areaRepository.GetAreasAsync();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
        return Ok(areas);
    }
    [HttpGet]
    public ActionResult<SingleResult> Get([FromRoute] int key)
    {
        var area = _areaRepository.GetAreaByIdAsync(key);

        if (area == null)
        {
            return NotFound();
        }

        return Ok(new SingleResult<Area>(area));
    }
    [HttpPost]
    [Authorize(Roles = "Staff")]
    public async Task<ActionResult<Area>> Post([FromBody] AreaDto dto)
    {
        Area area;
        try
        {
            area = mapper.Map<Area>(dto);
            await _areaRepository.AddAreaAsync(area);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return CreatedAtAction("Get", new { key = area.Id }, area);
    }
    [HttpPut]
    [Authorize(Roles = "Staff")]
    public async Task<IActionResult> Put([FromRoute] int key, [FromBody] AreaDto dto)
    {
        try
        {
            var area = mapper.Map<Area>(dto);
            area.Id = key;
            await _areaRepository.UpdateAreaAsync(area);
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
            await _areaRepository.SoftDeleteAreaAsync(key);
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
