using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Todo.DomainModel
{
    /// <summary>
    /// The Task class represents work that is assigned to a particular User.
    /// </summary>
    public class Task : Aggregate
    {
        /// <summary>
        /// Constructor is used internally within the domain model to create a task with a specific user as the creator.
        /// </summary>
        /// <param name="description">A brief description of the task.</param>
        /// <param name="creator">The creator of the task.</param>
        internal Task(string description, User creator)
        {
            description.ThrowIfNullOrEmpty();
            Description = description;

            creator.ThrowIfNull();
            CreatedBy = creator;
            AssignedTo = creator;
            ModifiedBy = creator;
        }

        protected Task()
        {
        }

        private string m_Description = null;

        /// <summary>
        /// The description of the task.
        /// </summary>
        public string Description
        {
            get
            {
                return m_Description;
            }

            set
            {
                value.ThrowIfNullOrEmpty();
                m_Description = value;
            }
        }

        private User m_CreatedBy = null;

        /// <summary>
        /// The User that created the task.
        /// </summary>
        public virtual User CreatedBy
        {
            get
            {
                return m_CreatedBy;
            }

            protected set
            {
                value.ThrowIfNull();
                m_CreatedBy = value;
            }
        }

        private User m_AssignedTo = null;

        /// <summary>
        /// The User that the task is assigned to.
        /// </summary>
        public virtual User AssignedTo
        {
            get
            {
                return m_AssignedTo;
            }

            protected set
            {
                value.ThrowIfNull();
                m_AssignedTo = value;
            }
        }

        private User m_ModifiedBy = null;

        /// <summary>
        /// The User that the task was last modified by.
        /// </summary>
        public virtual User ModifiedBy
        {
            get
            {
                return m_ModifiedBy;
            }

            protected set
            {
                value.ThrowIfNull();
                m_ModifiedBy = value;
            }
        }
        
        public virtual Status Status { get; set; }
        
        public virtual Collection<Tag> Tags { get; set; }
    }
}
