using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BallongAB.Models;
using BallongAB.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BallongAB.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        private readonly IProjectRepository _projectRepository;
        public int ProjectId { get; set; }
        public List<Order> Orders { get; set; }
        public ProjectController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public IActionResult Index()
        {
            ProjectListViewModel projectListViewModel = new ProjectListViewModel()
            {
                Projects = _projectRepository.AllProjects
        };

            return View(projectListViewModel);
        }
    }
}