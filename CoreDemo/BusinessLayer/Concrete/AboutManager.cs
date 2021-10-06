using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutdal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutdal = aboutDal;
        }

        public List<About> GetList()
        {
            return _aboutdal.GetListAll();
        }
    }

}
