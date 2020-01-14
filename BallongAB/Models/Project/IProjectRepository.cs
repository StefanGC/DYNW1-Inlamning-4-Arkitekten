using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BallongAB.Models
{
    public interface IProjectRepository
    {
        public IEnumerable<Project> AllProjects { get; }
        public Project GetProjectById(int projectId);
    }
}
