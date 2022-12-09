using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Service.Contracts;

namespace ProjectManagement.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectController : ControllerBase
    {

        private IServiceManager _service;

        public ProjectController(IServiceManager service)
        {
            _service = service;
           
        }


        [HttpGet]
        public IActionResult Get()
        {
            

            var list = _service.ProjectService.GetAllProjects(false);
                return Ok(list);
        }
    }
}
