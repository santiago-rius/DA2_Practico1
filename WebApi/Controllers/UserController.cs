using Domain;
using IBusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Models.Out;

namespace WebApi;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private IUserService _UserService;
    public UserController(IUserService userService){
        _UserService = userService;
    }
    [HttpGet]
    public IActionResult Get()
    {
        IQueryable<User> users = _UserService.GetAll();
        return Ok (users);
    }

    [HttpPost]
    public IActionResult Add([FromBody] User user)
    {
        try
        {
            var createdUser = _UserService.Create(user);
            return CreatedAtRoute("AddUser", new UserBasicInfoModel()
            {
                Id = createdUser.Id,
                Name = createdUser.Name,
                Surname = createdUser.Surname
            });
        }
        catch (ArgumentException ex)
        {
            return BadRequest();
        }
    }

    [HttpDelete]
    public IActionResult Remove([FromBody] User user)
    {
        try
        {
            _UserService.Delete(user);
            return Ok();
        }
        catch (ArgumentException ex)
        {
            return BadRequest();
        }
    }
}