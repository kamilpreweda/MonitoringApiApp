using Microsoft.AspNetCore.Mvc;



namespace MonitoringApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly ILogger<UsersController> _logger;

    public UsersController(ILogger<UsersController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        try
        {
            if (id < 0 || id > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }

            _logger.LogInformation(@"The api\Users\{id} was called", id);
            return Ok($"Value{id}");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "The given Id of {Identifier} was invalid.", id);
            return BadRequest("The index was out of range.");
        }
    }

    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
