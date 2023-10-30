using DataAccess.Commons;
using Application.IRepositories;
using Application.IServices;
using Application.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZooManagementWebApi.DTOs;

namespace ZooManagementWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAccountRepository _accountRepo;
    private readonly IClaimService _claimService;
    private readonly AppConfiguration _config;
    public AuthController(IAccountRepository accountRepo, IClaimService claimService,
                            AppConfiguration configuration)
    {
        _accountRepo = accountRepo;
        _claimService = claimService;
        _config = configuration;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto dto)
    {
        var response = new ApiResponse();
        try
        {
            var account = await _accountRepo.GetAccountByUsernameAsync(dto.UserName);
            if (account == null || !dto.Password.Verify(account.Password))
            {
                response.Success = false;
                response.ErrorMessage = "Wrong username/password!";
            } 
            else if (account.IsDeleted){
                response.Success = false;
                response.ErrorMessage = "This account has been inactive!";
            }
            else
            {
                var token = account.GenerateJsonWebToken(_config.JwtConfiguration.SecretKey, DateTime.Now);
                response.Success = true;
                response.Value = token;
                return Ok(response);
            }
        }
        catch (Exception ex)
        {
            response.Success = false;
            response.ErrorMessage = ex.Message;            
        }
        return BadRequest(response);
    }

    [HttpGet("current-id")]
    [Authorize]
    public IActionResult GetCurrentId()
    {
        var response = new ApiResponse()
        {
            Success = true,
            Value = _claimService.GetCurrentUserId
        };
        return Ok(response);
    }

    [HttpGet("current-username")]
    [Authorize]
    public IActionResult GetCurrentUserName()
    {
        var response = new ApiResponse()
        {
            Success = true,
            Value = _claimService.GetCurrentUserName
        };
        return Ok(response);
    }
    [HttpGet("exist")]
    [Authorize]
    public async Task<IActionResult> IsUsernameExist(string username)
    {
        var user = await _accountRepo.GetAccountByUsernameAsync(username);
        if (user == null) return NotFound($"user :{username.Trim()} not found!");
        var response = new ApiResponse()
        {
            Success = true,
            Value = $"User {user.Username} Exist"
        };
        return Ok(response);
    }
    [HttpGet("forgotpassword")]
    [Authorize]
    public async Task<IActionResult> Forgotpassword(string username,string phone)
    {
        var user = await _accountRepo.GetAccountByUsernameAsync(username);
        if (user == null) return NotFound($"user :{username.Trim()} not found!");

        return Ok();
    }

    [HttpGet("current-user")]
    [Authorize]
    public async Task<IActionResult> GetCurrentUser()
    {
        var userId = _claimService.GetCurrentUserId;
        var user = await _accountRepo.GetAccountByIdAsync(userId);

        if (user != null)
        {
            var response = new ApiResponse()
            {
                Success = true,
                Value = user
            };
            return Ok(response);
        }
        else
        {
            return NotFound(new ApiResponse
            {
                Success = false,
                ErrorMessage = "Something wrong! User Id not found."
            });
        }
    }
}
