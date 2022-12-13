using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    public class ProjectService : IProjectService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProjectService(IRepositoryManager repository,
            ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<ProjectDto> GetAllProjects(bool trackChanges)
        {
            var projects = _repository.Project.GetAllProjects(trackChanges);
            var projectDtos = _mapper.Map<IEnumerable<ProjectDto>>(projects);
            return projectDtos;
        }

        public ProjectDto GetOneProjectById(Guid id, bool trackChanges)
        {
            var project = _repository.Project.GetOneProjectById(id, trackChanges);
            if (project == null)
            {
                throw new ProjectNotFoundException(id);
            }
            var projetDto = _mapper.Map<ProjectDto>(project);
            return projetDto;
        }

        public ProjectDto CreateOneProject(ProjectDtoForCreation projectDto)
        {
            var entity = _mapper.Map<Project>(projectDto); 
            _repository.Project.CreateProject(entity);
            _repository.Save();

            //Entity -> Dto
            return _mapper.Map<ProjectDto>(entity);
        }
    }
}