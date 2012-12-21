using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Todo.DomainModel
{
    public class Status : Aggregate
    {
        public string Text { get; set; }
        public virtual Collection<Task> Tasks { get; set; }
    }
}
