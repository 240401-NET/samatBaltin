namespace CaseStatusTrackerAPI.Models;

public class CaseStatus{
    public int StatusId {get; set;}
    public string CaseId {get; set;}
    public DateTime date {get; set;}
    public string Message {get; set;}
}