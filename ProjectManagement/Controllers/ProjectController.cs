﻿using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectManagement.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private List<Project> _projectList;
        private ILogger<ProjectController> _logger;

        public ProjectController(ILogger<ProjectController> logger)
        {
            _logger = logger;
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
            try
            {
                int c = 10;
                int a = 0;
                int d = c / a;

                _logger.LogInformation("Projects.Get() has been run.");
                return Ok(_projectList);
            }
            catch (Exception ex)
            {
                _logger.LogError("Project.Get() has been crashed : " + ex.Message);
                throw;
            }


        }
    }
}
