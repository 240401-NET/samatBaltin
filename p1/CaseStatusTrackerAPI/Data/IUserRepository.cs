namespace CaseStatusTrackerAPI.Data;

public interface IUserRepository {
    IEnumerable<User> GetAllUsers();
    User? GetUserById(int userId);
    User CreateUser(User user);
    void DeleteUserById(int userId);
    void UpdateUser(User user);
}