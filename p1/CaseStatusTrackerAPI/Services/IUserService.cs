namespace CaseStatusTrackerAPI.Services;

public interface IUserService{
    IEnumerable<User> GetAllUsers();
    User? GetUserById(int userId);
    User CreateUser(User user);
    void DeleteUserById(int userId);
    void UpdateUser(User user);
}