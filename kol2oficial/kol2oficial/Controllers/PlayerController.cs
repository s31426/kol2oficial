using kol2oficial.Services;
using Microsoft.AspNetCore.Mvc;

namespace kol2oficial.Controllers;
[ApiController]
[Microsoft.AspNetCore.Components.Route("api/[controller]")]
public class PlayerController :ControllerBase
{
    private readonly IDbService _dbService;

    public PlayerController(IDbService dbService)
    {
        _dbService = dbService;
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrder(int id)
    {
        try
        {
            var order = await _dbService.GetMatchesById(id);
            return Ok(order);
        }
        catch (Exception e)
        {
            return NotFound();
        }
    }
}