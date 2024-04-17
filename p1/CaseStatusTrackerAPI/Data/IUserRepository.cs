namespace CaseStatusTrackerAPI.Data;

public interface IUserRepository {
    IEnumerable<User> GetAllUsers();
    User? GetUserById(int userId);
    void CreateUser(User user);
    void DeleteUserById(int userId);
    void UpdateUser(User user);
}