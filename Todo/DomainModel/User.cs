using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Todo.DomainModel
{
    /// <summary>
    /// The User class represents a person or system which interacts with the TODO application.
    /// </summary>
    public class User : Aggregate
    {
        /// <summary>
        /// Initializes a new instance of the User class with an e-mail address.
        /// </summary>
        /// <param name="emailAddress">The e-mail address of the user.</param>
        public User(string emailAddress)
        {
            emailAddress.ThrowIfNullOrEmpty();
            emailAddress.ThrowIfInvalidEmailAddress();
            EmailAddress = emailAddress;
            Tasks = new Collection<Task>();
        }

        private string m_EmailAddress = null;

        /// <summary>
        /// Gets the user's e-mail address.
        /// </summary>
        public string EmailAddress
        {
            get
            {
                return m_EmailAddress;
            }

            protected set
            {
                value.ThrowIfNullOrEmpty();
                value.ThrowIfInvalidEmailAddress();
                m_EmailAddress = value;
            }
        }

        /// <summary>
        /// Gets a collection of the Tasks assigned to the user.
        /// </summary>
        public virtual Collection<Task> Tasks { get; protected set; }

        public Task CreateTask(string description)
        {
            description.ThrowIfNullOrEmpty();

            var task = new Task(description, this);
            Tasks.Add(task);

            return task;
        }
    }
}
