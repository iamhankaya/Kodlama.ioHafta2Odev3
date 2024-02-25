using Kodlama.ioHafta2Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioHafta2Odev3.DataAccess.Abstract
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        void Add(Course course);
    }
}
