﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Core.models;

namespace Courses.Core.Services
{
    public interface IStudentService
    {
        public IEnumerable<Student> GetList();
        public Student GetById(int id);
        public void Add(Student student);
        public void Update(int id, Student student);
        public void UpdateStatus(int id, bool status);
    }
}
