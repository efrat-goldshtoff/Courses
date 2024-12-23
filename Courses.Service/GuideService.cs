﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Core.models;
using Courses.Core.Repositories;
using Courses.Core.Services;

namespace Courses.Service
{
    public class GuideService:IGuideService
    {
        private readonly IGuideRepository _courseRepository;
        public GuideService(IGuideRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public IEnumerable<Guide> GetList()
        {
            return _courseRepository.GetList();
        }

        public Guide? GetById(int id)
        {
            return _courseRepository.GetById(id);
        }

        public void Add(Guide guide)
        {
            _courseRepository.Add(guide);
        }

        public void Update(int id, Guide guide)
        {
            _courseRepository.Update(id, guide);
        }

        public void UpdateStatus(int id, bool status)
        {
            _courseRepository.UpdateStatus(id, status);
        }
    }
}
