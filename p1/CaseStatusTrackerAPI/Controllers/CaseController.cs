using Microsoft.AspNetCore.Mvc;
using CaseStatusTrackerAPI.Data;
using CaseStatusTrackerAPI.Services;

namespace CaseStatusTrackerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CaseController : ControllerBase
{
    private ICaseService _caseService;

    public CaseController (ICaseService caseService){
        _caseService = caseService;
    }

    //get all cases
    [HttpGet("getAllCases")]
    public ActionResult GetAllCases()
    {
        return Ok(_caseService.GetAllCases());
    }

    
    //get case by user id
    [HttpGet("getAllCasesByUser")]
    public ActionResult getAllCasesByUserId([FromQuery] int userId){
        var cases = _caseService.GetAllCasesByUserId(userId);
        if (cases == null || !cases.Any()){
            return NoContent(); // Return 204 No Content if no cases are found
        }
        return Ok(cases); // Return 200 OK with the list of cases if found
    }

    //get case by user id
    [HttpGet("getCaseByCaseId")]
    public ActionResult getCaseById([FromQuery] string receiptNumber){
        var cases = _caseService.GetCaseById(receiptNumber);
        if (cases == null){
            return NoContent(); // Return 204 No Content if no cases are found
        }
        return Ok(cases); // Return 200 OK with the list of cases if found
    }

    //create case
    [HttpPost]
    public ActionResult<Case> createNewCase([FromBody] Case newCase){
        Case entity = _caseService.CreateCase(newCase);
        if(entity != null){
            Created();
            return entity;
        }
        return NoContent();
    }

    [HttpPut("updateCase")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public void updateUser([FromBody] Case myCase){
        _caseService.UpdateCase(myCase); 
    }

}
