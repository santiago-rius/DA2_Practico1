using Domain;
using IBusinessLogic;
using IDataAccess;

namespace BusinessLogic;

public class UserService : IUserService
{
    private IUserRepository _repository;
    public UserService(IUserRepository userRepository)
    {
        _repository = userRepository;
    }
    
    public User Get(int id)
    {
        throw new NotImplementedException();
    }

    public User Create(User user)
    {
        _repository.Add(user);
        return user;
    }

    public IQueryable<User> GetAll()
    {
        return _repository.GetAll();
    }

    public void Delete(User user)
    {
        _repository.Remove(user);
    }
}