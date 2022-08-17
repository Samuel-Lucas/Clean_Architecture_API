using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public  DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET CORE 1", "Descrição 1", 1, 1, 1000),
                new Project("Meu projeto ASPNET CORE 2", "Descrição 2", 1, 1, 2000),
                new Project("Meu projeto ASPNET CORE 3", "Descrição 3", 1, 1, 3000)
            };

            Users = new List<User>
            {
                new User("Samuel", "samuel@email.com", new DateTime(1996, 1, 1)),
                new User("Lucas", "lucas@email.com", new DateTime(1997, 1, 1)),
                new User("Emanuel", "emanuel@email.com", new DateTime(1999, 1, 1))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("Angular"),
                new Skill("Python"),
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}