﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
