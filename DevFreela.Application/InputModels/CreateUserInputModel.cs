using System;

namespace DevFreela.Application.InputModels
{
    public class CreateUserInputModel
    {
        public string FullName { get; set; }     
        public string Email { get; set; }
        public DateTime BirthDate { get; private set; }
        public string Password { get; set; }
    }
}