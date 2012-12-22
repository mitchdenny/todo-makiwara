using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.DomainModel;

namespace Todo.Repositories
{
    public interface ITaskRepository : IRepository<Task>
    {
    }
}
