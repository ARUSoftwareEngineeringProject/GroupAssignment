using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using temp1;

namespace StaffTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoginTest()
        {
            Staff staff = new Staff();
            //Arrange
            var newStaff = new Logging();

            // Act
            bool result = newStaff.DoLogin(" ", "test");

            // Assert
            Assert.IsTrue(result);
        }
        public class Logging
        {
            public bool DoLogin(string username, string password)
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    return false;

                return true;
            }
        }
    }
}