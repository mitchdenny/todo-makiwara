using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.DomainModel;

namespace Todo.Tests.DomainModel
{
    [TestClass]
    public class TaskTests
    {
        [TestMethod]
        public void GivenValidUserWhenTaskCreatedUserIsAssignedToCreatedByProperty()
        {
            // Arrange.
            var validUser = new User("someone@somewhere.com");

            // Act.
            var task = validUser.CreateTask("Pick up milk.");

            // Assert.
            Assert.AreEqual(validUser, task.CreatedBy);
        }

        [TestMethod]
        public void GivenValidUserWhenTaskCreatedUserIsAssignedToAssignedToProperty()
        {
            // Arrange.
            var validUser = new User("someone@somewhere.com");

            // Act.
            var task = validUser.CreateTask("Pick up milk.");

            // Assert.
            Assert.AreEqual(validUser, task.AssignedTo);
        }

        [TestMethod]
        public void GivenValidUserWhenTaskCreatedUserIsAssignedToModifiedByProperty()
        {
            // Arrange.
            var validUser = new User("someone@somewhere.com");

            // Act.
            var task = validUser.CreateTask("Pick up milk.");

            // Assert.
            Assert.AreEqual(validUser, task.ModifiedBy);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GivenNullUserWhenTaskConstructedExceptionIsThrown()
        {
            // Arrange. 
            var description = "Pick up milk.";

            // Act.
            new Task(description, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GivenNullDescriptionWhenTaskConstructedExceptionIsThrown()
        {
            // Arrange.
            var validUser = new User("someone@somewhere.com");

            // Act.
            new Task(null, validUser);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GivenEmptyDescriptionWhenTaskConstructedExceptionIsThrown()
        {
            // Arrange.
            var validUser = new User("someone@somewhere.com");

            // Act.
            new Task(string.Empty, validUser);
        }

        [TestMethod]
        public void GivenValidUserAndDescriptionThenDescriptionSetCorrectly()
        {
            // Arrange.
            var validDescription = "Pick up milk.";
            var validUser = new User("someone@somewhere.com");

            // Act.
            var task = new Task(validDescription, validUser);

            // Assert.
            Assert.AreEqual(validDescription, task.Description);
        }
    }
}
