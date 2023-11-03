using Application.IRepositories;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZooManagementWebApi.DTOs;

namespace ZooManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CageHistoryController : ControllerBase
    {
        private readonly ICageHistoryRepository cageHistoryRepository;
        private readonly IMapper mapper;
        public CageHistoryController(ICageHistoryRepository cageHistoryRepository, IMapper mapper)
        {
            this.cageHistoryRepository = cageHistoryRepository;
            this.mapper = mapper;
        }
        [HttpPost]
        [Authorize(Roles = "Staff,Admin")]
        public async Task<ActionResult<Area>> Post(CageHistoryDto dto)
        {
            CageHistory cageHistory;
            try
            {
                cageHistory = mapper.Map<CageHistory>(dto);
                await cageHistoryRepository.AddCageHistoryAsync(cageHistory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }
    }
}
