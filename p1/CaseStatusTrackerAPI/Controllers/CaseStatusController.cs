// using Microsoft.AspNetCore.Mvc;
// using System.Threading.Tasks;
// using CaseStatusTrackerAPI.Services;

// namespace CaseStatusTrackerAPI.Controllers;

// [ApiController]
// [Route("[controller]")]
// public class CaseStatusController : ControllerBase {
//     private readonly UscisApiService _uscisApiService;

//     public CaseStatusController(UscisApiService uscisApiService)
//     {
//         _uscisApiService = uscisApiService;
//     }

//     [HttpGet("{caseId}")]
//     public async Task<IActionResult> GetCaseStatus(string caseId)
//     {
//         try
//         {
//             var caseStatus = await _uscisApiService.GetCaseStatusAsync(caseId);
//             return Ok(caseStatus);
//         }
//         catch (HttpRequestException)
//         {
//             return StatusCode(500, "Failed to retrieve case status from USCIS API.");
//         }
//     }

// }