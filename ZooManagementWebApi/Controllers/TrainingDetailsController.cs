using Application.IRepositories;
using Application.IServices;
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
    private readonly IClaimService _claimService;

    public TrainingDetailsController(ITrainingDetailRepository trainingDetailRepository, 
                                        IMapper mapper, 
                                        IClaimService claimService)
    {
        _trainingDetailRepository = trainingDetailRepository;
        _mapper = mapper;
        _claimService = claimService;
    }

    // GET: odata/TrainingDetails
    [HttpGet]
    public ActionResult<IQueryable<TrainingDetail>> Get()
    {
        IQueryable<TrainingDetail> trainingDetails;
        try
        {
            trainingDetails = _trainingDetailRepository.GetQueryTrainingDetails();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
        return Ok(trainingDetails);
    }

    // GET: odata/TrainingDetails/5
    [HttpGet]
    public ActionResult<IQueryable<TrainingDetail>> Get([FromRoute] int key)
    {
        var trainingDetail = _trainingDetailRepository.GetQueryTrainingDetailById(key);

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

    //[HttpGet("api/trainingDetails/animals")]
    //public async Task<IActionResult> GetOwnTrainginAnimal()
    //{
    //    var trainerId = _claimService.GetCurrentUserId;
    //    var trainingDetail = (await _trainingDetailRepository.GetAllTrainingDetailsAsync())
    //                            .Where(x => x.TrainerId == trainerId);

    //    if (trainingDetail == null)
    //    {
    //        return NotFound();
    //    }

    //    return Ok(trainingDetail);
    //}
}
