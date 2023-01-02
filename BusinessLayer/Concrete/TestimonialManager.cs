using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : IGenericService<Testimontial>
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public Testimontial GetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public List<Testimontial> GetList()
        {
            return _testimonialDal.GetList();
        }

        public void TAdd(Testimontial t)
        {
            _testimonialDal.Insert(t);
        }

        public void TDelete(Testimontial t)
        {
            _testimonialDal.Delete(t);
        }

        public void TUpdate(Testimontial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
