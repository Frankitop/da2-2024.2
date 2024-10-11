using IBusinessLogic;
using IDataAccess;
namespace BusinessLogic
{
    class UserLogic : IUserLogic
    {
        private IUserRepository _userRepository;
        public UserLogic(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool IsTheCorrectUser(Guid userToken)
        {
            return _userRepository.ExistUserByToken(userToken);
        }
    }
}
