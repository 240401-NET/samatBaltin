namespace CaseStatusTrackerAPI.Data;


public class UserRepository : IUserRepository, IDisposable{
    private CaseStatusDbContext context;

    public UserRepository (CaseStatusDbContext context){
        this.context = context;
    }

    public IEnumerable<User> GetUsers(){
        IEnumerable<User> usersList = context.Users.ToList();
        Console.WriteLine(usersList.Count());
        foreach(User u in usersList){
            Console.WriteLine(u);
        }
        return usersList;
    }

    public User GetUserById(int userId){
        return null;
    }
    public void InsertUser(User user){

    }
    public void DeleteUser(int userId){

    }
    public void UpdateUser(User user){

    }
    public void Save(){

    }
    private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
}