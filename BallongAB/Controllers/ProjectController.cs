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
        private readonly IOrderRepository _orderRepository;
        public int ProjectId { get; set; }
        public List<Order> Orders { get; set; }
        public ProjectController(IProjectRepository projectRepository, IOrderRepository orderRepository)
        {
            _projectRepository = projectRepository;
            _orderRepository = orderRepository;
        }
        public IActionResult Index(int projectId)
        {
            ProjectListViewModel projectListViewModel = new ProjectListViewModel()
            {
                Projects = _projectRepository.AllProjects,
                Project  = _projectRepository.GetProjectById(1),
                Orders   = _orderRepository.GetOrderByPorjectId(1).ToList()
            };

            return View(projectListViewModel);
        }
    }
}