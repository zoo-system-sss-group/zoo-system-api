using Application.Commons;
using Application.IRepositories;
using Application.IServices;
using Application.Repositories;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ZooManagementWebApi.DTOs;

namespace ZooManagementWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NewController : ControllerBase
{
    private readonly INewRepository _newRepo;
    private readonly IClaimService _claimService;
    public NewController(INewRepository newRepo, IClaimService claimService)
    {
        this._newRepo = newRepo;
        _claimService = claimService;
    }
    [EnableQuery(PageSize = 1)]
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
    [EnableQuery]
    public async Task<IActionResult> Add(News news)
    {
        await _newRepo.AddNews(news);
        return Ok(news);
    }
    [EnableQuery]
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, News news)
    {
        if (await TryFind(id)) return NotFound();
        await _newRepo.AddNews(news);
        return Ok(news);
    }

   

    [EnableQuery]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Remove(int id )
    {
        var news = _newRepo.GetNews(id);
        if (news == null) return NotFound();
        return Ok(news);
    }
    private async Task<bool> TryFind(int id)
    {
        return await _newRepo.GetNews(id) == null;
    }
}
