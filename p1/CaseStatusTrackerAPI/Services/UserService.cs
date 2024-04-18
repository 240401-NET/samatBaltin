using CaseStatusTrackerAPI.Data;

namespace CaseStatusTrackerAPI.Services;

public class UserService : IUserService {

    private readonly IUserRepository _userRepo;
    private readonly ICaseService _caseService;

    public UserService(IUserRepository userRepository, ICaseService caseService){
        _userRepo = userRepository;
        _caseService = caseService;
    }

    public User CreateUser(User user)
    {
        return _userRepo.CreateUser(user);
    }

    public void DeleteUserById(int userId)
    {
        _caseService.RemoveUserFromCase(userId);
        _userRepo.DeleteUserById(userId);
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _userRepo.GetAllUsers();
    }

    public User? GetUserById(int userId)
    {
        return _userRepo.GetUserById(userId);
    }

    public void UpdateUser(User user)
    {
        _userRepo.UpdateUser(user);
    }
}