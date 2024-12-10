using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Core.models;
using Courses.Core.Repositories;

namespace Courses.Data.Repositories
{
    public class GuideRepository : IGuideRepository
    {
        private readonly DataContext _context;
        public GuideRepository(DataContext context)
        {
            _context = context;
        }
        public List<Guide> GetList()
        {
            return _context.guiders;
        }

        public Guide GetById(int id)
        {
            foreach (var guide in _context.guiders)
            {
                if (guide.Id == id)
                {
                    return guide;
                }
            }
            return null;
        }

        public void Add(Guide guide)
        {
            _context.guiders.Add(guide);
        }

        public void Update(int id, Guide guide)
        {
            Guide g = GetById(id);
            if (g == null)
                return;
            else
            {
                g.Name = guide.Name;
                g.IsActive = guide.IsActive;
            }
        }

        public void UpdateStatus(int id, bool status)
        {
            Guide g = GetById(id);
            if (g != null)
                g.IsActive = status;
        }
    }
}
