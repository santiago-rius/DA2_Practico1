using Domain;
using IDataAccess;

namespace DataAccess;

public class UserRepository : IUserRepository
{

    private ContextDb _contextDb;

    public UserRepository(ContextDb contextDb)
    {
        _contextDb = contextDb;
    }
    
    public void Add(User entity)
    {
        _contextDb.Users.Add(entity);
        _contextDb.SaveChanges();
    }

    public void Remove(User entity)
    {
        _contextDb.Users.Remove(entity);
        _contextDb.SaveChanges();
    }

    public IQueryable<User> GetAll()
    {
        return _contextDb.Users;
    }
}