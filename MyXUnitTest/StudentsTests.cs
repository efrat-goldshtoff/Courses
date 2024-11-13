using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Controllers;
using Courses.models;
using Microsoft.AspNetCore.Mvc;

namespace MyXUnitTest
{
    public class StudentsTests:StudentsController
    {
        [Fact]
        public void GetAll_returnsListStudents()
        {
            var controller = new StudentsTests();
            var result = controller.Get();
            Assert.IsType <List<Student>>(result);
        }
        [Fact]
        public void GetById_returnsOk()
        {
            int id = 1;
            var controller = new StudentsTests();
            var result = controller.Get(id);
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void GetById_ReturnsNotFoundId()
        {
            //Arange
            int id1 = int.MaxValue;
            //Act
            var contrller = new StudentsTests();
            var result = contrller.Get(id1);
            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

    }
}
