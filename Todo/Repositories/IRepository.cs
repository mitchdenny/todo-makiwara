using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.DomainModel;

namespace Todo.Repositories
{
    public interface IRepository
    {
        Aggregate GetByID(Guid aggregateID);
    }
}
