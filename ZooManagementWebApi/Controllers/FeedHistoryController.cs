using Application.IRepositories;
using Application.IServices;
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
    public class FeedHistoryController : ControllerBase
    {
        private readonly IFeedHistoryRepository feedHistoryRepository;
        private readonly IMapper mapper;
        private readonly IClaimService claimService;
        public FeedHistoryController(IFeedHistoryRepository feedHistoryRepository, IMapper mapper, IClaimService claimService)
        {
            this.feedHistoryRepository = feedHistoryRepository;
            this.mapper = mapper;
            this.claimService = claimService;
        }

        [HttpGet]
        public ActionResult<IQueryable<FeedHistory>> Get()
        {
            IQueryable<FeedHistory> feedHistories;
            try
            {
                feedHistories = feedHistoryRepository.GetFeedHistoriesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(feedHistories);
        }
        [HttpGet]
        public ActionResult<SingleResult> Get([FromRoute] int key)
        {
            var feedHistory = feedHistoryRepository.GetFeedHistoryByIdAsync(key);

            if (feedHistory == null)
            {
                return NotFound();
            }

            return Ok(new SingleResult<FeedHistory>(feedHistory));
        }

        [HttpPost]
        [Authorize(Roles = "Trainer")]
        public async Task<ActionResult<FeedHistory>> Post([FromBody] List<FeedHistoryDto> dto)
        {
            List<FeedHistory> feedHistory;
            try
            {
                feedHistory = mapper.Map<List<FeedHistory>>(dto);
                foreach(FeedHistory history in feedHistory)
                {   
                    history.TrainerId = claimService.GetCurrentUserId;
                }
                await feedHistoryRepository.AddFeedHistoryAsync(feedHistory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromRoute] int key, [FromBody] FeedHistoryDto dto)
        {
            try
            {
                var feedHistory = mapper.Map<FeedHistory>(dto);
                feedHistory.Id = key;
                await feedHistoryRepository.UpdateFeedHistoryAsync(feedHistory);
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
        public async Task<IActionResult> Delete([FromRoute] int key)
        {
            try
            {
                await feedHistoryRepository.SoftDeleteFeedHistoryAsync(key);
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
