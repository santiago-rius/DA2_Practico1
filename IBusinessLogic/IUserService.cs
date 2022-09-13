using Domain;

namespace IBusinessLogic;

public interface IUserService
{
    User Get (int id);
    User Create (User user);
    IQueryable<User> GetAll();
    void Delete(User user);
}