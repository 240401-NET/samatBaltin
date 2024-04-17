using Microsoft.AspNetCore.Mvc;
using CaseStatusTrackerAPI.Data;

namespace CaseStatusTrackerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private IUserRepository _userRepo;

    public UserController(IUserRepository userRepository)
    {
        _userRepo = userRepository;
    }

    //Retrieve all users
    [HttpGet("getAllUsers")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IEnumerable<User> Get()
    {
        var model = _userRepo.GetAllUsers();
        return model;
    }

    //Find user by Id
    [HttpGet("getUserById")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public User getUserById([FromQuery] int userId){
        return _userRepo.GetUserById(userId);
    }


    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public void createUser([FromBody] User user){
        _userRepo.CreateUser(user); 
    }

    [HttpDelete("deleteUser")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public void deleteUserById([FromQuery] int userId){
        _userRepo.deleteUserById(userId); 
    }

    [HttpPut("updateUser")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public void UpdateUser([FromBody] User user){
        _userRepo.UpdateUser(user); 
    }
}