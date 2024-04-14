// using Microsoft.AspNetCore.Mvc;
// using CaseStatusTrackerAPI.Data;

// namespace CaseStatusTrackerAPI.Controllers;

// [ApiController]
// [Route("[controller]")]
// public class UserController : ControllerBase
// {
//     private IUserRepository _userRepository;
//     private readonly ILogger<UserController> _logger;

//     public UserController(IUserRepository userRepository, ILogger<UserController> logger)
//     {
//         _userRepository = userRepository;
//         _logger = logger;
//     }

//     [HttpGet(Name = "GetUsers")]
//     public IEnumerable<User> Get()
//     {
//         Console.WriteLine("Controller called");
//         var model = _userRepository.GetUsers();
//         return model;
//     }
// }