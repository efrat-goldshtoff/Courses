using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courses.Core.models;
using Courses.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Courses.Data.Repositories
{
    public class GuideRepository : IGuideRepository
    {
        private readonly DataContext _context;
        public GuideRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Guide> GetList()
        {
            return _context.guiders.Include(g => g.Courses);
        }

        public Guide GetById(int id)
        {
            return _context.guiders.First(g => g.Id == id);
            //foreach (var guide in _context.guiders)
            //{
            //    if (guide.Id == id)
            //    {
            //        return guide;
            //    }
            //}
            //return new Guide();
        }

        public Guide Add(Guide guide)
        {
            _context.guiders.Add(guide);
            _context.SaveChanges();
            return guide;
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
            _context.SaveChanges();
        }

        public void UpdateStatus(int id, bool status)
        {
            Guide g = GetById(id);
            if (g != null)
                g.IsActive = status;
            _context.SaveChanges();
        }
    }
}
