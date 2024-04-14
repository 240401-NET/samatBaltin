namespace CaseStatusTrackerAPI.Data;

public interface IUserRepository : IDisposable{
    IEnumerable<User> GetUsers();
    User GetUserById(int userId);
    void InsertUser(User user);
    void DeleteUser(int userId);
    void UpdateUser(User user);
    void Save();
}