using AutoFixture;
using FoodDonationManagementSystem.Controllers;
using FoodDonationManagementSystem.Models;
using FoodDonationManagementSystem.Repositry;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Linq;

namespace TestProject
{
    [TestClass]
    public class ManagementControllerTest
    {
       private Mock<Imanagement> _managementRepo;
        private Fixture _fixture;
        private ManagementsController _controller;

        public ManagementControllerTest()
        {
            _fixture = new Fixture();
            _managementRepo = new Mock<Imanagement>();
        }
            [TestMethod]
            public void Get_EmployeeModels_Return()
            {
                var employeeList = _fixture.CreateMany<Management>(3).ToList();

            _managementRepo.Setup(Repository => Repository.Get()).Returns(employeeList);

                _controller = new ManagementsController(_managementRepo.Object);

                var result = _controller.Get();
                var obj = result as ObjectResult;

                Assert.AreEqual(200, obj.StatusCode);
            }
            [TestMethod]
            public void Get_Employee_ThrowException()
            {
            _managementRepo.Setup(repo => repo.Get()).Throws(new Exception());

                _controller = new ManagementsController(_managementRepo.Object);

                var result = _controller.Get();
                var obj = result as ObjectResult;

                Assert.AreEqual(200, obj.StatusCode);
            }
            [TestMethod]
            public void Post_Employee_ReturningOK()
            {
                var employee = _fixture.Create<Management>();

            _managementRepo.Setup(repo => repo.Post(It.IsAny<Management>())).Returns(employee);
                _controller = new ManagementsController(_managementRepo.Object);

                var result = _controller.Get();
                var obj = result as ObjectResult;

                Assert.AreEqual(200, obj.StatusCode);
            }

        
           
        }
    }