using CaseStatusTrackerAPI;
using CaseStatusTrackerAPI.Data;
using CaseStatusTrackerAPI.Services;
using Moq;

namespace CaseStatusTrackerTest;

public class CaseServiceTest{

    [Fact]
    public void CaseService_GetAllCases_returns_Cases(){
        Mock<ICaseRepository> caseRepoMock = new Mock<ICaseRepository>();        
        IEnumerable<Case> fakeCases = [
            new Case{
                ReceiptNumber = "ioe1234567890",
                FormType = "I-130",
                SubmittedDate = new DateTime(2015, 12, 25),
                UserId = 1,
                CaseStatuses = []
            }
        ];

        caseRepoMock.Setup(repo => repo.GetAllCases()).Returns(fakeCases);
        CaseService service = new CaseService(caseRepoMock.Object);
        IEnumerable<Case> allCases = service.GetAllCases();

        Assert.Single(allCases);
    }


    [Fact]
    public void CaseService_CreateUser_returns_newCase(){
        Mock<ICaseRepository> caseRepoMock = new Mock<ICaseRepository>();        
        Case newCase = new Case();
        newCase.ReceiptNumber = "ioe1234567890";
        newCase.FormType = "I-130";
        newCase.SubmittedDate = new DateTime(2015, 12, 25);
        newCase.UserId = 1;
        newCase.CaseStatuses = [];

        caseRepoMock.Setup(repo => repo.CreateCase(newCase)).Returns(newCase);
        CaseService service = new CaseService(caseRepoMock.Object);

        Assert.Equal(newCase, service.CreateCase(newCase));
    }

    [Fact]
    public void CaseService_GetAllCasesByUserId_returns_Cases(){
        Mock<ICaseRepository> caseRepoMock = new Mock<ICaseRepository>();        
        IEnumerable<Case> fakeCases = [
            new Case{
                ReceiptNumber = "ioe1234567890",
                FormType = "I-130",
                SubmittedDate = new DateTime(2015, 12, 25),
                UserId = 1,
                CaseStatuses = []
            }
        ];

        caseRepoMock.Setup(repo => repo.GetAllCasesByUserId(1)).Returns(fakeCases);
        CaseService service = new CaseService(caseRepoMock.Object);
        IEnumerable<Case> allCases = service.GetAllCasesByUserId(1);

        Assert.Single(allCases);
    }

    [Fact]
    public void CaseService_GetCaseById_returns_Case(){
        Mock<ICaseRepository> caseRepoMock = new Mock<ICaseRepository>();        
        Case newCase = new Case();
        newCase.ReceiptNumber = "ioe1234567890";
        newCase.FormType = "I-130";
        newCase.SubmittedDate = new DateTime(2015, 12, 25);
        newCase.UserId = 1;
        newCase.CaseStatuses = [];

        caseRepoMock.Setup(repo => repo.GetCaseById("ioe1234567890")).Returns(newCase);
        CaseService service = new CaseService(caseRepoMock.Object);

        Assert.Equal(newCase, service.GetCaseById("ioe1234567890"));
    }

    [Fact]
    public void CaseService_RemoveUserFromCase_returns_Case_NoUserId(){
        Mock<ICaseRepository> caseRepoMock = new Mock<ICaseRepository>();        
        Case newCase = new Case();
        newCase.ReceiptNumber = "ioe1234567890";
        newCase.FormType = "I-130";
        newCase.SubmittedDate = new DateTime(2015, 12, 25);
        newCase.UserId = 1;
        newCase.CaseStatuses = [];

        Case newCase2 = new Case();
        newCase2.ReceiptNumber = "ioe1234567890";
        newCase2.FormType = "I-130";
        newCase2.SubmittedDate = new DateTime(2015, 12, 25);
        newCase2.UserId = null;
        newCase2.CaseStatuses = [];

        caseRepoMock.Setup(repo => repo.RemoveUserFromCase(1)).Returns(newCase2);
        CaseService service = new CaseService(caseRepoMock.Object);

        Assert.Equal(newCase2, service.RemoveUserFromCase(1));
    }

    [Fact]
    public void CaseService_UpdateCase_calls_UpdateCase(){
        Mock<ICaseRepository> caseRepoMock = new Mock<ICaseRepository>();        
        Case newCase = new Case();
        newCase.ReceiptNumber = "ioe1234567890";
        newCase.FormType = "I-130";
        newCase.SubmittedDate = new DateTime(2015, 12, 25);
        newCase.UserId = 1;
        newCase.CaseStatuses = [];

        CaseService service = new CaseService(caseRepoMock.Object);

        service.UpdateCase(newCase);

        caseRepoMock.Verify(repo => repo.UpdateCase(newCase), Times.Exactly(1));
    }
}