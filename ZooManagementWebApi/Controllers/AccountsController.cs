using Application.IRepositories;
using Application.Utils;
using AutoMapper;
using Domain.Entities;
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

    public AccountsController(IAccountRepository AccountRepository, IMapper mapper)
    {
        _accountRepository = AccountRepository;
        _mapper = mapper;
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
    [Authorize(Roles = "Staff")]
    public async Task<IActionResult> Put([FromRoute] int key, [FromBody] AccountDto dto)
    {
        try
        {
            var account = _mapper.Map<Account>(dto);
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
    [Authorize(Roles = "Staff")]
    public async Task<ActionResult<Account>> Post([FromBody] AccountDto dto)
    {
        if (dto.Password == null)
        {
            return BadRequest("Password is required");
        }
        Account account;
        try
        {
            account = _mapper.Map<Account>(dto);
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
    [Authorize(Roles = "Staff")]
    public async Task<IActionResult> Delete([FromRoute] int key)
    {
        try
        {
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
