using CaseStatusTrackerAPI;
using CaseStatusTrackerAPI.Data;
using CaseStatusTrackerAPI.Services;
using Moq;

namespace CaseStatusTrackerTest;

public class UserServiceTest
{
    [Fact]
    public void UserService_GetAllUsers_returns_Users(){
        Mock<IUserRepository> userRepoMock = new Mock<IUserRepository>();
        Mock<ICaseRepository> caseRepoMock = new Mock<ICaseRepository>();        
        IEnumerable<User> fakeUsers = [
            new User{
                UserId = 1,
                UserName = "Bob",
                Email = "bob@gmail.com"
            }
        ];

        userRepoMock.Setup(repo => repo.GetAllUsers()).Returns(fakeUsers);
        CaseService caseService = new CaseService(caseRepoMock.Object);
        UserService service = new UserService(userRepoMock.Object, caseService);

        IEnumerable<User> allUsers = service.GetAllUsers();

        Assert.Single(allUsers);
    }

    [Theory]
    [InlineData(1)]
    public void UserService_GetUserById_returns_User(int userId){
        Mock<IUserRepository> userRepoMock = new Mock<IUserRepository>();
        Mock<ICaseRepository> caseRepoMock = new Mock<ICaseRepository>();        
        User user = new User();
        user.UserId = 1;
        user.UserName = "Bob";
        user.Email = "bob@gmail.com";

        userRepoMock.Setup(repo => repo.GetUserById(userId)).Returns(user);
        CaseService caseService = new CaseService(caseRepoMock.Object);
        UserService service = new UserService(userRepoMock.Object, caseService);

        User? newUser = service.GetUserById(userId);

        Assert.Equal(user, newUser);
    }

    [Theory]
    [InlineData(1)]
    public void UserService_DeleteUserById_calls_Repo_DeleteUserById(int userId){
        Mock<IUserRepository> userRepoMock = new Mock<IUserRepository>();
        Mock<ICaseRepository> caseRepoMock = new Mock<ICaseRepository>();

        CaseService caseService = new CaseService(caseRepoMock.Object);
        UserService service = new UserService(userRepoMock.Object, caseService);

        service.DeleteUserById(userId);

        userRepoMock.Verify(repo => repo.DeleteUserById(userId), Times.Exactly(1));
    }

    [Fact]
    public void UserService_CreateUser_returns_createdUser(){
        Mock<IUserRepository> userRepoMock = new Mock<IUserRepository>();
        Mock<ICaseRepository> caseRepoMock = new Mock<ICaseRepository>();

        User user = new User();
        user.UserId = 1;
        user.UserName = "Bob";
        user.Email = "bob@gmail.com";
        
        userRepoMock.Setup(repo => repo.CreateUser(user)).Returns(user);

        CaseService caseService = new CaseService(caseRepoMock.Object);
        UserService service = new UserService(userRepoMock.Object, caseService);

        User newUser = service.CreateUser(user);

        Assert.Equal(user, newUser);    
    }
    [Fact]
    public void UserService_UpdateUser_calls_Repo_UpdateUser(){
        Mock<IUserRepository> userRepoMock = new Mock<IUserRepository>();
        Mock<ICaseRepository> caseRepoMock = new Mock<ICaseRepository>();

        User user = new User();
        user.UserId = 1;
        user.UserName = "Bob";
        user.Email = "none@mail.com";
        
        CaseService caseService = new CaseService(caseRepoMock.Object);
        UserService service = new UserService(userRepoMock.Object, caseService);

        service.UpdateUser(user);

        userRepoMock.Verify(repo => repo.UpdateUser(user), Times.Exactly(1));    
    }

}