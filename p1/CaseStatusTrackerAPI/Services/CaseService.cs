
using CaseStatusTrackerAPI.Data;

namespace CaseStatusTrackerAPI.Services;

public class CaseService : ICaseService
{

    private readonly ICaseRepository _caseRepo;

    public CaseService(ICaseRepository caseRepository){
        _caseRepo = caseRepository;
    }

    public Case CreateCase(Case myCase)
    {
        return _caseRepo.CreateCase(myCase);
    }

    public IEnumerable<Case> GetAllCases()
    {
        return _caseRepo.GetAllCases();
    }

    public IEnumerable<Case> GetAllCasesByUserId(int userId)
    {
        return _caseRepo.GetAllCasesByUserId(userId);
    }

    public Case? GetCaseById(string receiptNumber)
    {
        return _caseRepo.GetCaseById(receiptNumber);
    }

    public Case? RemoveUserFromCase(int userId)
    {
        return _caseRepo.RemoveUserFromCase(userId);
    }

    public void UpdateCase(Case myCase)
    {
        _caseRepo.UpdateCase(myCase);
    }
}