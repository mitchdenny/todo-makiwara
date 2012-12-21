using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Todo.DomainModel
{
    public class User : Aggregate
    {
        public string EmailAddress { get; set; }
        public virtual Collection<Task> Tasks { get; set; }
    }
}
