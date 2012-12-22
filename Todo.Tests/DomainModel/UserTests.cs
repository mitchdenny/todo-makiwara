using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.DomainModel;

namespace Todo.Tests.DomainModel
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void GivenValidEmailAddressWhenUserIsCreatedEmailAddressIsAssigned()
        {
            // Arrange.
            var validEmailAddress = "mitch@mitchdenny.com";

            // Act.
            var user = new User(validEmailAddress);

            // Assert.
            Assert.AreEqual(validEmailAddress, user.EmailAddress);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void GivenInvalidEmailAddressWhenUserIsCreatedExceptionIsThrown()
        {
            // Arrange.
            var invalidEmailAddress = "invalidemailaddress";

            // Act.
            var user = new User(invalidEmailAddress);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GivenEmptyStringAsEmailAddressWhenUserIsCreatedExceptionIsThrown()
        {
            // Act.
            var user = new User(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GivenNullAsEmailAddressWhenUserIsCreatedExceptionIsThrown()
        {
            // Act.
            var user = new User(null);
        }

        [TestMethod]
        public void GivenValidUserWhenTaskCreatedIsAddedToUserTasksList()
        {
            // Arrange.
            var validUser = new User("someone@somewhere.com");

            // Act.
            var task = validUser.CreateTask("Pick up milk.");

            // Assert.
            Assert.IsTrue(validUser.Tasks.Contains(task));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GivenValidUserWhenTaskCreatedWithNullDescriptionExceptionIsThrown()
        {
            // Arrange.
            var validUser = new User("someone@somewhere.com");

            // Act.
            validUser.CreateTask(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GivenValidUserWhenTaskCreatedWithEmptyStringDescriptionExceptionIsThrown()
        {
            // Arrange.
            var validUser = new User("someone@somewhere.com");

            // Act.
            validUser.CreateTask(string.Empty);
        }
    }
}
