using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IUserService
    {
        void Post(CreateUserInputModel inputModel);
        UserViewModel GetById(int id);
        void Update(int id, LoginInputModel inputModel);
    }
}