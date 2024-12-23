using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Core.models;

namespace Courses.Core.Services
{
    public interface IGuideService
    {
        public IEnumerable<Guide> GetList();
        public Guide? GetById(int id);
        public void Add(Guide guide);
        public void Update(int id, Guide guide);
        public void UpdateStatus(int id, bool status);
    }
}
