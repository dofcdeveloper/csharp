using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private static List<User> _users = new List<User>();

    [HttpPost]
    public IActionResult Register(User user)
    {
        _users.Add(user);
        return Ok();
    }

    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok(_users);
    }
}

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
