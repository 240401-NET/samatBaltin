using Microsoft.EntityFrameworkCore;

namespace CaseStatusTrackerAPI.Data;

public class CaseRepository : ICaseRepository {
    private readonly CaseStatusDbContext _context;

    public CaseRepository (CaseStatusDbContext context){
        _context = context;
    }

    public Case CreateCase(Case newCase)
    {
        _context.Cases.Add(newCase);
        _context.SaveChanges();
        return newCase;
    }

    public IEnumerable<Case> GetAllCases()
    {
        return _context.Cases.
        Include(c => c.CaseStatuses).
        ToList();
    }

    public IEnumerable<Case> GetAllCasesByUserId(int userId)
    {
        return _context.Cases.Include(c => c.CaseStatuses).Where(e => e.UserId == userId).ToList();
    }

    public Case? GetCaseById(string receiptNumber)
    {
        return _context.Cases.
        Include(c => c.CaseStatuses).
        FirstOrDefault(c => c.ReceiptNumber.Equals(receiptNumber));
    }

    public Case? RemoveUserFromCase(int userId)
    {
        Case? myCase = _context.Cases.FirstOrDefault(c => c.UserId == userId);
        if(myCase != null){
            myCase.UserId = null;
            _context.SaveChanges();
            return myCase;
        }
        return null;
    }

    public void UpdateCase(Case newCase)
    {
        var entity = GetCaseById(newCase.ReceiptNumber);
        if(entity != null){
            entity.ReceiptNumber = newCase.ReceiptNumber;
            entity.FormType = newCase.FormType ?? entity.FormType;
            entity.SubmittedDate = newCase.SubmittedDate ?? entity.SubmittedDate;
            entity.UserId = newCase.UserId ?? entity.UserId;
            _context.SaveChanges();
        }
    }
}