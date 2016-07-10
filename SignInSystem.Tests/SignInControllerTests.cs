using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SignInSystem.Tests;
using SignInSystem.Models;
using SignInSystem.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;

namespace SignInSystem.Tests
{
    [TestClass]
    public class SignInControllerTests
    {
        [TestMethod]
        public void ReportPage_ReturnsInfo()
        {
            //Arrange
            var controller = new SignInController(new AttendeeStubFileDAL());

            //Act
            var result = controller.Report() as ViewResult;
            var model = result.Model as List<Attendee>;

            //Assert
            Assert.IsNotNull(model);
            Assert.AreEqual("Report", result.ViewName);
            Assert.AreEqual(2, model.Count);

        }
    }
}
