﻿using Application.IRepositories;
using Application.IServices;
using Application.Repositories;
using AutoMapper;
using DataAccess.DAOs;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using ZooManagementWebApi.DTOs;

namespace ZooManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedHistoryController : ControllerBase
    {
        private readonly IFeedHistoryRepository feedHistoryRepository;
        private readonly IMapper mapper;
        private readonly IClaimService claimService;
        private readonly IDietRepository dietRepository;
        public FeedHistoryController(IFeedHistoryRepository feedHistoryRepository, 
                                    IMapper mapper, 
                                    IClaimService claimService,
                                    IDietRepository dietRepository)
        {
            this.feedHistoryRepository = feedHistoryRepository;
            this.mapper = mapper;
            this.claimService = claimService;
            this.dietRepository = dietRepository;
        }
        [HttpGet]
        [Authorize]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<FeedHistory>>> Get()
        {
            IQueryable<FeedHistory> feedHistories;
            try
            {
                feedHistories = feedHistoryRepository.GetFeedHistories();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(feedHistories);
        }
        [HttpGet("{key}")]
        [Authorize(Roles = "Trainer")]
        public async Task<IActionResult> Get([FromRoute] int key)
        {
            var feedHistories = await feedHistoryRepository.GetTodayFeedHistoriesByAnimalId(key);
            if (feedHistories == null || feedHistories.Count() == 0)
            {
                var diet = await dietRepository.GetCurrentDietOfAnimalAsync(key);
                if (diet != null)
                {
                    TimeSpan startTime = new TimeSpan(7, 0, 0);
                    TimeSpan endTime = new TimeSpan(19, 0, 0);
                    int timesPerDay = diet.TimesPerDay;
                    TimeSpan timeInterval = new TimeSpan((endTime - startTime).Ticks / (timesPerDay-1));

                    for (int i = 0; i < timesPerDay; i++)
                    {
                        TimeSpan feedingTime = startTime + timeInterval * i;

                        DateTime feedingDateTime = DateTime.Today.Add(feedingTime);

                        await feedHistoryRepository.AddFeedHistoryAsync(new FeedHistory
                        {
                            AnimalId = key,
                            DietId = diet.Id,
                            FeedingDate = feedingDateTime,
                            TrainerId = claimService.GetCurrentUserId
                        });
                    }
                }
                else throw new Exception("this animal does not have a diet");
                feedHistories = await feedHistoryRepository.GetTodayFeedHistoriesByAnimalId(key);
            }

            return Ok(feedHistories);
        }
        [HttpPut("{key}")]
        [Authorize(Roles = "Trainer")]
        public async Task<IActionResult> Put([FromRoute] int key)
        {
            var feedHistories = await feedHistoryRepository.GetByIdAsync(key);
            if (feedHistories == null)
                throw new Exception("can not found");
            if (feedHistories.IsDeleted == true)
                feedHistories.IsDeleted = false;
            else
                feedHistories.IsDeleted = true;
            await feedHistoryRepository.UpdateFeedHistoryAsync(feedHistories);
            return Ok(feedHistories);
        }
    }
}
