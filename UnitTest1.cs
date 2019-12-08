using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using Xunit;
using zorgapp;

namespace zorgappTests
{
    [TestClass]
    public class DoctorControllerSameWeekTests// : IClassFixture<WebApplicationFactory<zorgapp.Startup>>
    {
        [TestMethod]
        public void SameWeekTest1()
        {
            // Assert
            Assert.AreEqual(zorgapp.Controllers.DoctorController.SameWeek(new DateTime(2019, 11, 13), new DateTime(2019, 11, 14)), true);
        }

        [TestMethod]
        public void SameWeekTest2()
        {
            // Assert
            Assert.AreEqual(zorgapp.Controllers.DoctorController.SameWeek(new DateTime(2018, 11, 12), new DateTime(2019, 11, 13)), false);
        }

        [TestMethod]
        public void SameWeekTest3()
        {
            // Assert
            Assert.AreEqual(zorgapp.Controllers.DoctorController.SameWeek(new DateTime(2019, 10, 12), new DateTime(2019, 11, 13)), false);
        }

        [TestMethod]
        public void SameWeekTest4()
        {
            // Assert
            Assert.AreEqual(zorgapp.Controllers.DoctorController.SameWeek(new DateTime(2019, 10, 29), new DateTime(2019, 11, 13)), false);
        }

        [TestMethod]
        public void SameWeekTest5()
        {
            // Assert
            Assert.AreEqual(zorgapp.Controllers.DoctorController.SameWeek(new DateTime(2019, 12, 31), new DateTime(2020, 1, 1)), true);
        }
    }

    [TestClass]
    public class ProgramGenerateLinkCodeTests// : IClassFixture<WebApplicationFactory<zorgapp.Startup>>
    {

        [TestMethod]
        public void GenerateLinkCodeTest1()
        {
            // Assert
            Assert.IsNotNull(zorgapp.Program.GenerateLinkCode());
        }
    }

    [TestClass]
    public class PatientControllerConfirmAuthorizationTests : IClassFixture<WebApplicationFactory<zorgapp.Startup>>
    {
        private readonly WebApplicationFactory<zorgapp.Startup> _factory;

        public PatientControllerConfirmAuthorizationTests(WebApplicationFactory<zorgapp.Startup> factory)
        {
            _factory = factory;
        }

        public PatientControllerConfirmAuthorizationTests()
        {
            _factory = new WebApplicationFactory<zorgapp.Startup>();
        }

        [TestMethod]
        public async Task ConfirmAuthorizationTest1()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/Patient/ConfirmAuthorization");

            // Assert
            Assert.AreEqual("text/html; charset=utf-8",
            response.Content.Headers.ContentType.ToString());
        }

        [TestMethod]
        public async Task ConfirmAuthorizationTest2()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/Patient/ConfirmAuthorization");

            // Assert
            Assert.AreEqual("text/html; charset=utf-8",
            response.Content.Headers.ContentType.ToString());
        }

        /*[TestMethod]
        public void PatientControllerConfirmAuthorizationTests()
        {
            // Arrange
            pcontroller = new zorgapp.Controllers.PatientController();

            // Assert
            Assert.ThrowsException(pcontroller.ConfirmAuthorization("ababbabba","232323232"));
        }*/
    }
}
