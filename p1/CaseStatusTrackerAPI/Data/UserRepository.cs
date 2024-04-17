namespace CaseStatusTrackerAPI.Data;


public class UserRepository : IUserRepository {
    private CaseStatusDbContext _context;

    public UserRepository (CaseStatusDbContext context){
        _context = context;
    }

    public void deleteUserById(int userId)
    {
        _context.Users.Remove(GetUserById(userId));
        _context.SaveChanges();
    }

    public User GetUserById(int userId)
    {
        return _context.Users.Find(userId);
    }

    public IEnumerable<User> GetAllUsers(){
        return _context.Users.ToList();
    }

    public void CreateUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
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