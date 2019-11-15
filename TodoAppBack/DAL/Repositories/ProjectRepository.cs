using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAppBack.DAL.Models;

namespace TodoAppBack.DAL.Repositories
{
    public interface IProjectRepository
    {
        Project GetProject(string Id);
        Project Create(Project project);
    }
    public class ProjectRepository : IProjectRepository
    {
        private TodoContext _db;

        public ProjectRepository(TodoContext database)
        {
            _db = database;
        }

        public Project GetProject(string Id)
        {
            return _db.Projects.FirstOrDefault(p => p.Id == Id);
        }

        public Project Create(Project project)
        {
            _db.Projects.Add(project);
            _db.SaveChanges();

            return project;
        }
    }
}
