using Application.Commons;
using Application.IRepositories;
using Application.IServices;
using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ZooManagementWebApi.DTOs;

namespace ZooManagementWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NewController : ODataController
{
    private readonly INewRepository _newRepo;
    private readonly IClaimService _claimService;
    private readonly IMapper _mapper;
    public NewController(INewRepository newRepo, IClaimService claimService, IMapper mapper)
    {
        _newRepo = newRepo;
        _claimService = claimService;
        _mapper = mapper;
    }
    [EnableQuery(PageSize =10)]
    [HttpGet()]
    public async Task<IActionResult> Get()
    {
        List<News> news = await _newRepo.GetNews();
        return Ok(news);
    }
    [EnableQuery]
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var news = await _newRepo.GetNews(id);
        return Ok(news);
    }

    [HttpPost]
    [Authorize(Roles ="Staff")]
    [EnableQuery]
    public async Task<IActionResult> Add(NewsDTO news)
    {
        var @new = _mapper.Map<News>(news);
        @new.CreatedBy = _claimService.GetCurrentUserId;
        @new.CreationDate = _claimService.GetCurrentTime;
        await _newRepo.AddNews(@new);
        return CreatedAtAction("Get",@new);
    }
    [EnableQuery]
    [HttpPut("{id}")]
    [Authorize(Roles = "Staff")]
    public async Task<IActionResult> Update(int id, NewsDTO news)
    {
        var @new =await _newRepo.GetNews(id);
        if (@new == null) return NotFound();
      
        @new = _mapper.Map(@news,@new);
        @new.ModifiedBy = _claimService.GetCurrentUserId;
        @new.ModificationDate = _claimService.GetCurrentTime;
        await _newRepo.UpdateNews(@new);
        return Ok(@new);
    }

   

    [EnableQuery]
    [HttpDelete("{id}")]
    [Authorize(Roles ="Staff")]
    public async Task<IActionResult> Remove(int id )
    {
        var news = _newRepo.GetNews(id);
        if (news == null) return NotFound();
        return Ok(news);
    }
}
