using Xunit;
using Moq;
using Microsoft.Extensions.Caching.Memory;
using CaseStatusTrackerAPI.Services;
using CaseStatusTrackerAPI;
using CaseStatusTrackerAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CaseStatusTrackerTests;

public class UserControllerTests{

    [Fact]
    public void GetUserById_WithValidUserId_ReturnsUser()
    {
        // Arrange
        int userId = 1;
        var mockUserService = new Mock<IUserService>();
        var mockMemoryCache = new Mock<IMemoryCache>();
        var controller = new UserController(mockUserService.Object, mockMemoryCache.Object);

        // Mock UserService to return a user with the given userId
        var expectedUser = new User { UserId = userId, UserName = "Test User", Email = "test@mail.com" };
        mockUserService.Setup(service => service.GetUserById(userId)).Returns(expectedUser);

        // Act
        var result = controller.getUserById(userId);

        // Assert
        Assert.IsType<ActionResult<User>>(result); // Check if the result is an OkObjectResult
        var actionResult = Assert.IsType<OkObjectResult>(result.Result);
        Assert.Equal(expectedUser, actionResult.Value); // Check if the returned user is the expected user
    }

    [Fact]
    public void GetUserById_WithInvalidUserId_ReturnsNoContent()
    {
        // Arrange
        int userId = 1; // Assuming user with this ID doesn't exist
        var mockUserService = new Mock<IUserService>();
        var mockMemoryCache = new Mock<IMemoryCache>();
        var controller = new UserController(mockUserService.Object, mockMemoryCache.Object);

        // Mock UserService to return null for the given userId
        mockUserService.Setup(service => service.GetUserById(userId)).Returns((User)null);

        // Act
        var result = controller.getUserById(userId);

        // Assert
        Assert.IsType<ActionResult<User>>(result); // Check if the result is an ActionResult<User>
        Assert.IsType<NoContentResult>(result.Result); // Assert that the inner result is a NoContentResult
    }

}