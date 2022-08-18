using System;
using System.Collections.Generic;
using System.Linq;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;

namespace DevFreela.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly DevFreelaDbContext _dbContext;

        public SkillService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public List<SkillViewModel> GetAll()
        {
            var skill = _dbContext.Skills;

            var skillsViewModel = skill
                .Select(i => new SkillViewModel(i.Id, i.Description)).ToList();

            return skillsViewModel;
        }
    }
}