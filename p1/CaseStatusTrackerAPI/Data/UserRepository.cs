using Microsoft.EntityFrameworkCore;

namespace CaseStatusTrackerAPI.Data;


public class UserRepository : IUserRepository {
    private readonly CaseStatusDbContext _context;

    public UserRepository (CaseStatusDbContext context){
        _context = context;
    }

    public void DeleteUserById(int userId)
    {
        var entity = GetUserById(userId);
        if(entity != null){
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }
    }

    public User? GetUserById(int userId)
    {
        return _context.Users.
            Include(u => u.Cases).
            ThenInclude(c => c.CaseStatuses).
            FirstOrDefault(u => u.UserId == userId);
    }

    public IEnumerable<User> GetAllUsers(){
        return _context.Users.
            Include(u => u.Cases).
            ThenInclude(c => c.CaseStatuses).
            ToList();
    }

    public User CreateUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        return user;
    }

    public void UpdateUser(User user)
    {
        var entity = GetUserById(user.UserId);
        if(entity != null){
            entity.UserName = user.UserName;
            entity.Email = user.Email;
            _context.SaveChanges();
        }
    }
}