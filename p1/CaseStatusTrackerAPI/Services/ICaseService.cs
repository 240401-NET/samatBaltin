namespace CaseStatusTrackerAPI.Services;

public interface ICaseService{
    IEnumerable<Case> GetAllCases();
    IEnumerable<Case> GetAllCasesByUserId(int userId);
    Case? GetCaseById(string receiptNumber);
    Case CreateCase(Case myCase);
    void UpdateCase(Case myCase);
    Case? RemoveUserFromCase(int userId);
}