namespace CaseStatusTrackerAPI.Services;

public interface ICaseStatusService{
    IEnumerable<CaseStatus> GetAllStatuses();
    IEnumerable<CaseStatus> GetAllStatusesByCaseId(string receiptNumber);
    CaseStatus? GetStatusById(int caseStatusId);
    CaseStatus CreateStatus(CaseStatus caseStatus);
    void UpdateCase(CaseStatus caseStatus);

}