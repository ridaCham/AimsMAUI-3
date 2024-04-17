using MAUIUI.Business.Abstract;
using MAUIUI.Core.Entities;
using MAUIUI.Core.Security.HashHelper;
using MAUIUI.Core.Utilities.Results;
using MAUIUI.DataAccess.Abstract;

namespace MAUIUI.Business.Concrete
{
    public class UserManager : IUserService
        {
            IuserDal userDal;

            public UserManager(IuserDal userDal)
            {
                this.userDal = userDal;
            }

            public IResult Add(string userName, string password)
            {
                byte[] passwordHash, passwordSalt;
                HashHelper.createPasswordHash(password, out passwordHash, out passwordSalt);
                var user = new User
                {
                    UserName = userName,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                };
                userDal.Add(user);
                return new SuccessResult();
            }

            public IResult Update(User user)
            {
                userDal.Update(user);
                return new SuccessResult();
            }

            public IDataResult<List<User>> Get()
            {
                return new SuccessDataResult<List<User>>(userDal.GetAll());
            }

            public IDataResult<User> GetByEmail(string email)
            {
                return new SuccessDataResult<User>(userDal.Get(p => p.UserName == email));
            }

            public IResult Login(string userName, string password, User user)
            {

                if (userName == null)
                {
                    return new ErrorResult("User name or password is incorrect");
                }

                if (!HashHelper.verifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                {
                    return new ErrorResult("User name or password is incorrect");
                }

                return new SuccessResult();
            }
        }
    }


