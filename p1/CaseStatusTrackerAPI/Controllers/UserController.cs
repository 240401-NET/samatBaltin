using Microsoft.AspNetCore.Mvc;
using CaseStatusTrackerAPI.Services;
using Microsoft.Extensions.Caching.Memory;

namespace CaseStatusTrackerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private IMemoryCache _memorycache;

    public UserController(IUserService userService, IMemoryCache memoryCache)
    {
        _userService = userService;
        _memorycache = memoryCache;
    }

    //Retrieve all users
    [HttpGet("getAllUsers")]
    public ActionResult<IEnumerable<User>> GetAllUsers()
    {
        IEnumerable<User> allUsers;
        if(_memorycache.TryGetValue("allUsers", out allUsers)){
            return Ok(allUsers);
        } else {
            allUsers = _userService.GetAllUsers();
            _memorycache.Set("allUsers", allUsers, new TimeSpan(0,0,30));
            return Ok(allUsers);
        }
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