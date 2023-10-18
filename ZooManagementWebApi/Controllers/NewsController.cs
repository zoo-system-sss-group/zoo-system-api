using Application.IRepositories;
using Application.IServices;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using ZooManagementWebApi.DTOs;

namespace ZooManagementWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NewsController : ControllerBase
{
    private readonly INewsRepository _newRepo;
    private readonly IClaimService _claimService;
    private readonly IMapper _mapper;
    public NewsController(INewsRepository newRepo, IClaimService claimService, IMapper mapper)
    {
        _newRepo = newRepo;
        _claimService = claimService;
        _mapper = mapper;
    }
    [EnableQuery(PageSize = 10)]
    [HttpGet()]
    public async Task<IActionResult> Get()
    {
        List<News> news = await _newRepo.GetNews();
        var response = new ApiResponse()
        {
            Success = news.Count > 0,
            Value = news,
            ErrorMessage = news.Count == 0 ? "No News Currently" : "",
        };
        return response.Success ? Ok(response) : NotFound(response);
    }
    [EnableQuery]
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var @new = await _newRepo.GetNews(id);
        var response = new ApiResponse()
        {
            Success = @new != null,
            Value = @new,
            ErrorMessage = @new == null ? "News Not Found" : "",// config xong thay no ngu ngu sao a
        };
        return response.Success ? Ok(response) : NotFound(response);// nhung ma dc cai Success voi message
    }
    [HttpPost]
    [Authorize(Roles = "Staff")]
    [EnableQuery]
    public async Task<IActionResult> Add(NewsDTO news)
    {
        var @new = _mapper.Map<News>(news);
        @new.CreationDate = _claimService.GetCurrentTime;
        await _newRepo.AddNews(@new);
        var response = new ApiResponse()
        {
            Success = true,
        };
        return CreatedAtAction("Get", new { id = @new.Id, response });
    }
    [EnableQuery]
    [HttpPut("{id}")]
    [Authorize(Roles = "Staff")]
    public async Task<IActionResult> Update(int id, NewsDTO news)
    {
        var @new = await _newRepo.GetNews(id);
        if (@new == null) return NotFound();

        @new = _mapper.Map(@news, @new);
        @new.ModificationDate = _claimService.GetCurrentTime;
        await _newRepo.UpdateNews(@new);
         var response = new ApiResponse()
        {
            Success = true,
        };
        return Ok(@new);
    }



    [EnableQuery]
    [HttpDelete("{id}")]
    [Authorize(Roles = "Staff")]
    public async Task<IActionResult> Remove(int id)
    {
        var news = _newRepo.GetNews(id);
        if (news == null) return NotFound();
        return NoContent();
    }
}
