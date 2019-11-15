using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoAppBack.DAL.Models;
using TodoAppBack.DAL.Repositories;

namespace TodoAppBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
        private IProjectRepository _projects;

        public ProjectController(IProjectRepository projectRepository)
        {
            _projects = projectRepository;
        }

        [HttpGet("{id}")]
        public IActionResult Get(string Id)
        {
            Project project = _projects.GetProject(Id);

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        public IActionResult Post(Project project)
        {
            Project proj = _projects.Create(project);

            return Ok(proj);
        }
    }
}
