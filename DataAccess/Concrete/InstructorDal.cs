using Kodlama.ioHafta2Odev3.DataAccess.Abstract;
using Kodlama.ioHafta2Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.ioHafta2Odev3.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal() 
        { 
            Instructor instructor = new Instructor()
            {
                Id=1, Name="Engin Demiroğ"
            };
            Instructor instructor1 = new Instructor()
            {
                Id = 2,
                Name = "Halit Enes Kalaycı"
            };

           instructors= new List<Instructor> { instructor, instructor1 };
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }
    }
}
