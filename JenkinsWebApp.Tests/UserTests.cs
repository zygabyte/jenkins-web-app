using JenkinsWebApp.Models;
using JenkinsWebApp.Utilities.Enums;
using JenkinsWebApp.Utilities.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsWebApp.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void GetUserType_UserAdmin_ReturnAdminString()
        {
            //arrange
            var user = new User
            {
                Email = "jamesdoe@venturegardengroup.com",
                FirstName = "James",
                LastName = "Doe",
                PhoneNumber = "09044922959",
                UserRole = UserRole.Admin
            };

            //act
            var result = UserService.GetUserType(user);

            //assert
            Assert.AreEqual("Admin", result);
        }

        [TestMethod]
        public void IsUserVggUser_HasVggMail_ReturnTrue()
        {
            //arrange
            var user = new User
            {
                Email = "jamesdoe@venturegardengroup.com",
                FirstName = "James",
                LastName = "Doe",
                PhoneNumber = "09044922959",
                UserRole = UserRole.Admin
            };

            //act
            var result = UserService.IsUserVggUser(user);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsUserVggUser_DoesntHasVggMail_ReturnFalse()
        {
            //arrange
            var user = new User
            {
                Email = "jamesdoe@gmail.com",
                FirstName = "James",
                LastName = "Doe",
                PhoneNumber = "09044922959",
                UserRole = UserRole.Admin
            };

            //act
            var result = UserService.IsUserVggUser(user);

            //assert
            Assert.IsFalse(result);
        }
    }
}
