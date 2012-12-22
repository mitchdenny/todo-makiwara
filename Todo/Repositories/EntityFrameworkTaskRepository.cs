using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.DomainModel;
using Todo.Services.Persistence;

namespace Todo.Repositories
{
    public class EntityFrameworkTaskRepository : EntityFrameworkRepositoryBase<Task>, ITaskRepository
    {
        public EntityFrameworkTaskRepository(IPersistenceService persistenceService)
            : base(persistenceService)
        {
        }
    }
}
