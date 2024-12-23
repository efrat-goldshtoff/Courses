using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Core.models;

namespace Courses.Core.Repositories
{
    public interface IGuideRepository
    {
        public IEnumerable<Guide> GetList();
        public Guide GetById(int id);
        public Guide Add(Guide guide);
        public void Update(int id, Guide guide);
        public void UpdateStatus(int id, bool status);
    }
}
