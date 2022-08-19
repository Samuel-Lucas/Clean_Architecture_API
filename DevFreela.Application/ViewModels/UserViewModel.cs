using System;
using System.Collections.Generic;
using DevFreela.Core.Entities;

namespace DevFreela.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(int id, string fullName, string email, DateTime birthDate)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Skills = new List<UserSkill>();
        }

        public int Id { get; set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public List<UserSkill> Skills { get; private set; }
    }
}