using CaseStatusTrackerAPI;
using CaseStatusTrackerAPI.Data;
using CaseStatusTrackerAPI.Services;
using Moq;

namespace CaseStatusTrackerTest;

public class CaseStatusTest{

    [Fact]
    public void CaseStatusService_GetAllStatuses_returns_Statuses(){
        Mock<ICaseStatusRepository> statusRepoMock = new Mock<ICaseStatusRepository>();        
        IEnumerable<CaseStatus> fakeStatuses = [
            new CaseStatus{
                StatusId = 1,
                ReceiptNumber = "ioe1234567890",
                ModifiedDate = new DateTime(2015, 12, 25),
                CurrentaseStatusText = "Approved",
                CurrentCaseStatusDesc = "Your case is approved"
            }
        ];

        statusRepoMock.Setup(repo => repo.GetAllStatuses()).Returns(fakeStatuses);
        CaseStatusService service = new CaseStatusService(statusRepoMock.Object);
        IEnumerable<CaseStatus> allStatuses = service.GetAllStatuses();

        Assert.Single(allStatuses);
    }

    [Fact]
    public void CaseStatusService_CreateStatus_returns_newStatuses(){
        Mock<ICaseStatusRepository> statusRepoMock = new Mock<ICaseStatusRepository>();        
        CaseStatus status = new CaseStatus();
        status.StatusId = 1;
        status.ReceiptNumber = "ioe1234567890";
        status.ModifiedDate = new DateTime(2015, 12, 25);
        status.CurrentaseStatusText = "Approved";
        status.CurrentCaseStatusDesc = "Your case is approved";

        statusRepoMock.Setup(repo => repo.CreateStatus(status)).Returns(status);
        CaseStatusService service = new CaseStatusService(statusRepoMock.Object);

        Assert.Equal(service.CreateStatus(status), status);
    }

    [Fact]
    public void CaseStatusService_GetAllStatusesByCaseId_returns_Statuses(){
        Mock<ICaseStatusRepository> statusRepoMock = new Mock<ICaseStatusRepository>();        
        IEnumerable<CaseStatus> fakeStatuses = [
            new CaseStatus{
                StatusId = 1,
                ReceiptNumber = "ioe1234567890",
                ModifiedDate = new DateTime(2015, 12, 25),
                CurrentaseStatusText = "Approved",
                CurrentCaseStatusDesc = "Your case is approved"
            }
        ];

        statusRepoMock.Setup(repo => repo.GetAllStatusesByCaseId("ioe1234567890")).Returns(fakeStatuses);
        CaseStatusService service = new CaseStatusService(statusRepoMock.Object);
        IEnumerable<CaseStatus> allStatuses = service.GetAllStatusesByCaseId("ioe1234567890");

        Assert.Single(allStatuses);
    }

    [Fact]
    public void CaseStatusService_GetStatusById_returns_statuses(){
        Mock<ICaseStatusRepository> statusRepoMock = new Mock<ICaseStatusRepository>();        
        CaseStatus status = new CaseStatus();
        status.StatusId = 1;
        status.ReceiptNumber = "ioe1234567890";
        status.ModifiedDate = new DateTime(2015, 12, 25);
        status.CurrentaseStatusText = "Approved";
        status.CurrentCaseStatusDesc = "Your case is approved";

        statusRepoMock.Setup(repo => repo.GetStatusById(1)).Returns(status);
        CaseStatusService service = new CaseStatusService(statusRepoMock.Object);

        Assert.Equal(service.GetStatusById(1), status);
    }

        [Fact]
    public void CaseStatusService_UpdateCase_calls_repo_UpdateCase(){
        Mock<ICaseStatusRepository> statusRepoMock = new Mock<ICaseStatusRepository>();        
        CaseStatus status = new CaseStatus();
        status.StatusId = 1;
        status.ReceiptNumber = "ioe1234567890";
        status.ModifiedDate = new DateTime(2015, 12, 25);
        status.CurrentaseStatusText = "Approved";
        status.CurrentCaseStatusDesc = "Your case is approved";
        
        statusRepoMock.Setup(repo => repo.GetStatusById(1)).Returns(status);

        CaseStatusService service = new CaseStatusService(statusRepoMock.Object);
        service.UpdateCase(status);

        statusRepoMock.Verify(repo => repo.UpdateCase(status), Times.Exactly(1));
    }
}