using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BallongAB.Models
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProjectRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Project> AllProjects
        {
            get
            {
                return _appDbContext.Projects;
            }
        }

        public Project GetProjectById(int projectId)
        {
            return _appDbContext.Projects.FirstOrDefault(p => p.ProjectId == projectId);
        }
    }
}