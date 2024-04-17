using Microsoft.AspNetCore.Mvc;
using CaseStatusTrackerAPI.Data;

namespace CaseStatusTrackerAPI.Controllers;

[ApiController]
// [Route("")]
public class UserController : ControllerBase
{
    private IUserRepository _userRepository;

    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet("getAllUsers")]
    public IEnumerable<User> Get()
    {
        var model = _userRepository.GetAllUsers();
        return model;
    }
}