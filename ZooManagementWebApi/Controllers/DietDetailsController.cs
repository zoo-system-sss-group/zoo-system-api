using Application.IRepositories;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace ZooManagementWebApi.Controllers;

[EnableQuery]
[Authorize]
public class DietDetailsController :ControllerBase
{
    private readonly IDietDetailRepository _dietDetailRepository;
    private readonly IMapper _mapper;

    public DietDetailsController(IDietDetailRepository dietDetailRepository,
                                        IMapper mapper)
    {
        _dietDetailRepository = dietDetailRepository;
        _mapper = mapper;
    }

    // GET: odata/DietDetails
    [HttpGet]
    public async Task<ActionResult<IEnumerable<DietDetail>>> Get()
    {
        List<DietDetail> DietDetails;
        try
        {
            DietDetails = await _dietDetailRepository.GetAllDietDetailsAsync();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
        return Ok(DietDetails);
    }

    // GET: odata/DietDetails/5
    [HttpGet]
    public async Task<ActionResult<DietDetail>> Get([FromRoute] int key)
    {
        var DietDetail = await _dietDetailRepository.GetDietDetailByIdAsync(key);

        if (DietDetail == null)
        {
            return NotFound();
        }

        return Ok(DietDetail);
    }

    // PUT: odata/DietDetails/5
    [HttpPut]
    [Authorize(Roles = "Staff")]
    public async Task<IActionResult> Put([FromRoute] int key, [FromBody] DietDetail dto)
    {
        try
        {
            var DietDetail = _mapper.Map<DietDetail>(dto);
            DietDetail.Id = key;
            await _dietDetailRepository.UpdateDietDetailAsync(DietDetail);
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

    // POST: odata/DietDetails
    [HttpPost]
    [Authorize(Roles = "Staff")]
    public async Task<ActionResult<DietDetail>> Post([FromBody] DietDetail dto)
    {
        DietDetail DietDetail;
        try
        {
            DietDetail = _mapper.Map<DietDetail>(dto);
            await _dietDetailRepository.AddDietDetailAsync(DietDetail);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return CreatedAtAction("Get", new { key = DietDetail.Id }, DietDetail);
    }

    // DELETE: odata/DietDetails/5
    [HttpDelete]
    [Authorize(Roles = "Staff")]
    public async Task<IActionResult> Delete([FromRoute] int key)
    {
        try
        {
            await _dietDetailRepository.DeleteDietDetailAsync(key);
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
