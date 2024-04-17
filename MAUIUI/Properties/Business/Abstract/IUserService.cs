using MAUIUI.Core.Entities;
using MAUIUI.Core.Utilities.Results;

namespace MAUIUI.Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> Get();
        IDataResult<User> GetByEmail(string email);
        IResult Add(string userName, string password);
        IResult Update(User user);
        IResult Login(string userName, string password, User user);
    }
}

