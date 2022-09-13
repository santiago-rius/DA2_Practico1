using Domain;

namespace IDataAccess;

public interface IUserRepository
{
    void Add (User entity);
    void Remove (User entity);
    IQueryable<User> GetAll();
}