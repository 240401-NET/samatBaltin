using Microsoft.AspNetCore.Mvc;
using CaseStatusTrackerAPI.Services;

namespace CaseStatusTrackerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    //Retrieve all users
    [HttpGet("getAllUsers")]
    public ActionResult<IEnumerable<User>> GetAllUsers()
    {
        return Ok(_userService.GetAllUsers());
    }

    //Find user by Id
    [HttpGet("getUserById")]
    public ActionResult<User?> getUserById([FromQuery] int userId){
        User? user = _userService.GetUserById(userId);
        return user is not null ? Ok(user) : NoContent();
    }


    [HttpPost]
    public ActionResult<User> createUser([FromBody] User user){
        User newUser = _userService.CreateUser(user); 
        if(newUser != null){
            Created();
            return newUser;
        }
        return NoContent();
    }

    [HttpDelete("deleteUser")]
    public ActionResult deleteUserById([FromQuery] int userId){
        _userService.DeleteUserById(userId);
        return NoContent();
    }

    [HttpPut("updateUser")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public void updateUser([FromBody] User user){
        _userService.UpdateUser(user); 
    }
}