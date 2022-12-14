using System.Collections.Generic;
using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjectViewModel> GetAll();
        ProjectDetailsViewModel GetById(int id);
        int Create(NewProjectInputModel inputModel);
        void CreateComment(CreateCommentInputModel inputModel);
        void Update(UpdateProjectInputModel inputModel);
        void Delete(int id);
        void Start(int id);
        void Finish(int id);
    }
}