using Application.IRepositories;
using Application.IServices;
using Application.Utils;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using ZooManagementWebApi.DTOs;

namespace ZooManagementWebApi.Controllers;

[EnableQuery]
[Authorize]
public class AccountsController : ControllerBase
{
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;
    private readonly IClaimService _claimService;
    public AccountsController(IAccountRepository AccountRepository, 
                                IMapper mapper,
                                IClaimService claimService)
    {
        _accountRepository = AccountRepository;
        _mapper = mapper;
        _claimService = claimService;
    }

    // GET: odata/Accounts
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Account>>> Get()
    {
        List<Account> accounts; 
        try
        {
            accounts = await _accountRepository.GetAllAccountsAsync();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
        return Ok(accounts);
    }

    // GET: odata/Accounts/5
    [HttpGet]
    public async Task<ActionResult<Account>> Get([FromRoute] int key)
    {
        var account = await _accountRepository.GetAccountByIdAsync(key);

        if (account == null)
        {
            return NotFound();
        }

        return Ok(account);
    }

    // PUT: odata/Accounts/5
    [HttpPut]
    public async Task<IActionResult> Put([FromRoute] int key, [FromBody] AccountDto dto)
    {
        if (_claimService.GetCurrentRole.Equals("Staff") && 
                _claimService.GetCurrentUserId != key)
        {
            return BadRequest("Staff role can only edit own profile");
        }
        try
        {
            var currentRole = _claimService.GetCurrentRole;
            var account = _mapper.Map<Account>(dto);

            if (currentRole.Equals("Staff") && (account.Role == RoleEnum.Staff
                                                || account.Role == RoleEnum.Admin))
            {
                return BadRequest("Staff role can not update staff or admin account.");
            }

            account.Id = key;
            if (account.Password != null)
            {
                account.Password = account.Password.Hash();
            }            
            await _accountRepository.UpdateAccountAsync(account);
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

    // POST: odata/Accounts
    [HttpPost]
    [Authorize(Roles = "Staff,Admin")]
    public async Task<ActionResult<Account>> Post([FromBody] AccountDto dto)
    {
        if (dto.Password == null)
        {
            return BadRequest("Password is required");
        }
        Account account;
        try
        {
            var currentRole = _claimService.GetCurrentRole;
            account = _mapper.Map<Account>(dto);

            if (currentRole.Equals("Staff") && (account.Role == RoleEnum.Staff 
                                                || account.Role == RoleEnum.Admin))
            {
                return BadRequest("Staff role can not create staff or admin account.");
            }
            if (currentRole.Equals("Admin") && (account.Role == RoleEnum.Admin))
            {
                return BadRequest("You can not create admin account.");
            }     
            
            account.Password = account.Password.Hash();
            await _accountRepository.AddAccountAsync(account);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

        return CreatedAtAction("Get", new { key = account.Id }, account);
    }

    // DELETE: odata/Accounts/5
    [HttpDelete]
    [Authorize(Roles = "Staff,Admin")]
    public async Task<IActionResult> Delete([FromRoute] int key)
    {
        try
        {
            var currentRole = _claimService.GetCurrentRole;
            var account = await _accountRepository.GetAccountByIdAsync(key);

            if (currentRole.Equals("Staff") && (account!.Role == RoleEnum.Staff
                                                || account!.Role == RoleEnum.Admin))
            {
                return BadRequest("Staff role can not delete staff or admin account.");
            }
            if (currentRole.Equals("Admin") && (account!.Role == RoleEnum.Admin))
            {
                return BadRequest("You can not delete admin account.");
            }

            await _accountRepository.DeleteAccountAsync(key);
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
