//using System;
//using Courses;
//using Courses.Controllers;
//using Courses.models;
//using Microsoft.AspNetCore.Mvc;

//namespace MyXUnitTest
//{
//    public class StudentsTests:StudentsController
//    {
//        private readonly StudentsController _studentsController;
//        public StudentsTests(IDataContext context1) : base(context1)
//        {
//            FakeContext context = new FakeContext();
//            _studentsController = new StudentsController(context);
//        }
//        [Fact]
//        public void GetAll_returnsListStudents()
//        {
//            var controller = _studentsController;//new StudentsTests()
//            var result = controller.Get();
//            Assert.IsType <List<Student>>(result);
//        }
//        [Fact]
//        public void GetById_returnsOk()
//        {
//            int id = 1;
//            var controller = _studentsController;//new StudentsTests()
//            var result = controller.Get(id);
//            Assert.IsType<OkObjectResult>(result);
//        }
//        [Fact]
//        public void GetById_ReturnsNotFoundId()
//        {
//            //Arange
//            int id1 = int.MaxValue;
//            //Act
//            var contrller = _studentsController;//new StudentsTests()
//            var result = contrller.Get(id1);
//            //Assert
//            Assert.IsType<NotFoundResult>(result);
//        }

//    }
//}
