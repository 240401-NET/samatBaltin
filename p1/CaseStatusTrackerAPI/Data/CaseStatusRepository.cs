using Microsoft.EntityFrameworkCore;

namespace CaseStatusTrackerAPI.Data;

public class CaseStatusRepository : ICaseStatusRepository {
    private readonly CaseStatusDbContext _context;

    public CaseStatusRepository (CaseStatusDbContext context){
        _context = context;
    }

    public CaseStatus CreateStatus(CaseStatus caseStatus) {
        _context.CaseStatuses.Add(caseStatus);
        _context.SaveChanges();
        return caseStatus;
    }

    public IEnumerable<CaseStatus> GetAllStatuses() {
        return _context.CaseStatuses.ToList();
    }

    public IEnumerable<CaseStatus> GetAllStatusesByCaseId(string receiptNumber) {
        return  _context.CaseStatuses.Where(e => e.ReceiptNumber == receiptNumber).ToList();
    }

    public CaseStatus? GetStatusById(int caseStatusId) {
        return _context.CaseStatuses.Find(caseStatusId);
    }

    public void UpdateCase(CaseStatus caseStatus) {
        var entity = GetStatusById(caseStatus.StatusId);
        if(entity != null){
            entity.StatusId = caseStatus.StatusId;
            entity.ReceiptNumber = caseStatus.ReceiptNumber;
            entity.ModifiedDate = caseStatus.ModifiedDate ?? entity.ModifiedDate;
            entity. CurrentaseStatusText = caseStatus.CurrentaseStatusText ?? entity.CurrentaseStatusText;
            entity.CurrentCaseStatusDesc = caseStatus.CurrentCaseStatusDesc ?? entity.CurrentCaseStatusDesc;
        }
    }
}