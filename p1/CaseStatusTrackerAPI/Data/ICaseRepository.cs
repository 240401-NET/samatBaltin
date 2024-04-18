namespace CaseStatusTrackerAPI.Data;

public interface ICaseRepository {
    IEnumerable<Case> GetAllCases();

    IEnumerable<Case> GetAllCasesByUserId(int userId);
    Case? GetCaseById(string receiptNumber);
    Case CreateCase(Case newCase);
    void UpdateCase(Case newCase);
    Case? RemoveUserFromCase(int userId);
}