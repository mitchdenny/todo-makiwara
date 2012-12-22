using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.DomainModel;
using Todo.Services.Persistence;

namespace Todo.Repositories
{
    public class EntityFrameworkUserRepository : EntityFrameworkRepositoryBase<User>, IRepository<User>
    {
        public EntityFrameworkUserRepository(IPersistenceService persistenceService)
            : base(persistenceService)
        {
        }
    }
}
