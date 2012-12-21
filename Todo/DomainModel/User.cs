using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Todo.DomainModel
{
    public class User : Aggregate
    {
        public User(string emailAddress)
        {
            emailAddress.ThrowIfNullOrEmpty();
            emailAddress.ThrowIfInvalidEmailAddress();
            EmailAddress = emailAddress;
        }

        private string m_EmailAddress = null;

        public string EmailAddress
        {
            get
            {
                return m_EmailAddress;
            }

            set
            {
                value.ThrowIfNullOrEmpty();
                value.ThrowIfInvalidEmailAddress();
                m_EmailAddress = value;
            }
        }

        public virtual Collection<Task> Tasks { get; protected set; }
    }
}
