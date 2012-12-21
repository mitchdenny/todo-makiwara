using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace TodoMakiwara.DomainModel
{
    public class Task : Aggregate
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual User AssignedTo { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual Status Status { get; set; }
        public virtual Collection<Tag> Tags { get; set; }
    }
}
