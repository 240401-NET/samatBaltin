
using CaseStatusTrackerAPI.Data;

namespace CaseStatusTrackerAPI.Services;

public class CaseStatusService : ICaseStatusService
{
    private readonly ICaseStatusRepository _repo;

    public CaseStatusService(ICaseStatusRepository caseStatusRepository){
        _repo = caseStatusRepository;
    }
    public CaseStatus CreateStatus(CaseStatus caseStatus)
    {
        return _repo.CreateStatus(caseStatus);
    }

    public IEnumerable<CaseStatus> GetAllStatuses()
    {
        return _repo.GetAllStatuses();
    }

    public IEnumerable<CaseStatus> GetAllStatusesByCaseId(string receiptNumber)
    {
        return _repo.GetAllStatusesByCaseId(receiptNumber);
    }

    public CaseStatus? GetStatusById(int caseStatusId)
    {
        return _repo.GetStatusById(caseStatusId);
    }

    public void UpdateCase(CaseStatus caseStatus)
    {
        _repo.UpdateCase(caseStatus);
    }
}