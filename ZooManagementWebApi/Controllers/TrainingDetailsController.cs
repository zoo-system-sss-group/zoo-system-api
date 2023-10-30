using Application.IRepositories;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using ZooManagementWebApi.DTOs;

namespace ZooManagementWebApi.Controllers;

[EnableQuery]
[Authorize]
public class TrainingDetailsController : ControllerBase
{
    private readonly ITrainingDetailRepository _trainingDetailRepository;
    private readonly IMapper _mapper;

    public TrainingDetailsController(ITrainingDetailRepository trainingDetailRepository, 
                                        IMapper mapper)
    {
        _trainingDetailRepository = trainingDetailRepository;
        _mapper = mapper;
    }

    // GET: odata/TrainingDetails
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TrainingDetail>>> Get()
    {
        List<TrainingDetail> trainingDetails;
        try
        {
            trainingDetails = await _trainingDetailRepository.GetAllTrainingDetailsAsync();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
        return Ok(trainingDetails);
    }

    // GET: odata/TrainingDetails/5
    [HttpGet]
    public async Task<ActionResult<TrainingDetail>> Get([FromRoute] int key)
    {
        var trainingDetail = await _trainingDetailRepository.GetTrainingDetailByIdAsync(key);

        if (trainingDetail == null)
        {
            return NotFound();
        }

        return Ok(trainingDetail);
    }

    // PUT: odata/TrainingDetails/5
    [HttpPut]
    [Authorize(Roles = "Staff")]
    public async Task<IActionResult> Put([FromRoute] int key, [FromBody] TrainingDetailDto dto)
    {
        try
        {
            var trainingDetail = _mapper.Map<TrainingDetail>(dto);
            trainingDetail.Id = key;
            await _trainingDetailRepository.UpdateTrainingDetailAsync(trainingDetail);
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

    // POST: odata/TrainingDetails
    [HttpPost]
    [Authorize(Roles = "Staff")]
    public async Task<ActionResult<TrainingDetail>> Post([FromBody] TrainingDetailDto dto)
    {
        TrainingDetail trainingDetail;
        try
        {
            trainingDetail = _mapper.Map<TrainingDetail>(dto);
            await _trainingDetailRepository.AddTrainingDetailAsync(trainingDetail);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return CreatedAtAction("Get", new { key = trainingDetail.Id }, trainingDetail);
    }

    // DELETE: odata/TrainingDetails/5
    [HttpDelete]
    [Authorize(Roles = "Staff")]
    public async Task<IActionResult> Delete([FromRoute] int key)
    {
        try
        {
            await _trainingDetailRepository.DeleteTrainingDetailAsync(key);
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
