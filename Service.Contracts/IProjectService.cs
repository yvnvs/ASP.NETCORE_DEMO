﻿using Entities.Models;

namespace Service.Contracts
{
    public interface IProjectService
    {
        IEnumerable<Project> GetAllProjects(bool trackChanges);
        Project GetOneProjectById(Guid id, bool trackChanges);
    }
}