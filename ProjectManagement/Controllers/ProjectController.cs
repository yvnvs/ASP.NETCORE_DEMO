using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectManagement.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private List<Project> _projectList;

        public ProjectController()
        {
            _projectList = new List<Project>
            {
                new Project {Id = Guid.NewGuid(), Name = "Project 1" },
                new Project {Id = Guid.NewGuid(), Name = "Project 2" },
                new Project {Id = Guid.NewGuid(), Name = "Project 3" },
            };
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_projectList);
        }
    }
}
