using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IUserService
    {
        void Post(CreateUserModel inputModel);
        User GetById(int id);
        void Update(int id, LoginModel);
    }
}