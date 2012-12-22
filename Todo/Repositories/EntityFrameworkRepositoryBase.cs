using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.DomainModel;
using Todo.Services.Persistence;

namespace Todo.Repositories
{
    public class EntityFrameworkRepositoryBase<TAggregate> : IRepository<TAggregate> where TAggregate: Aggregate
    {
        public IPersistenceService PersistenceService { get; private set; }

        public EntityFrameworkRepositoryBase(IPersistenceService persistenceService)
        {
            PersistenceService = persistenceService;
        }

        public TAggregate GetByID(Guid aggregateID)
        {
            return default(TAggregate);
        }

        Aggregate IRepository.GetByID(Guid aggregateID)
        {
            return GetByID(aggregateID);
        }
    }
}
