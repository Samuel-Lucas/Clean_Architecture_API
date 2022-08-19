using System.Linq;
using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
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

        public UserViewModel GetById(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(i => i.Id == id);

            var usersViewModel = new UserViewModel(
                user.Id,
                user.FullName,
                user.Email,
                user.BirthDate
            );

            return usersViewModel;
        }

        public void Post(CreateUserInputModel inputModel)
        {
            var user = new User(
                inputModel.FullName,
                inputModel.Email,
                inputModel.Password,
                inputModel.BirthDate
            );

            _dbContext.Users.Add(user);
        }

        public void Update(int id, LoginInputModel inputModel)
        {
            throw new System.NotImplementedException();
        }
    }
}