namespace CaseStatusTrackerAPI.Data;


public class UserRepository : IUserRepository {
    private CaseStatusDbContext _context;

    public UserRepository (CaseStatusDbContext context){
        _context = context;
    }

    public void DeleteUser(int userId)
    {
        throw new NotImplementedException();
    }

    public User GetUserById(int userId)
    {
        return _context.Users.Find(userId);
    }

    public IEnumerable<User> GetAllUsers(){
        return _context.Users.ToList();
    }

    public void InsertUser(User user)
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}