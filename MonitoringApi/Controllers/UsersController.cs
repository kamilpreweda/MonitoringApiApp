using Microsoft.AspNetCore.Mvc;



namespace MonitoringApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        if(id < 0 || id > 100)
        {
            return BadRequest("The index was out of range.");
        }
        return Ok($"Value{id}");
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
