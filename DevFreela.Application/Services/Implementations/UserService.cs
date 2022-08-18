using DevFreela.Application.Services.Interfaces;
using DevFreela.Infrastructure.Persistence;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;

        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Post(CreateUserModel inputModel)
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, LoginModel inputModel)
        {
            throw new System.NotImplementedException();
        }
    }
}