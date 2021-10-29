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

		public About GetById(int id)
		{
			throw new System.NotImplementedException();
		}

		public List<About> GetList()
        {
            return _aboutdal.GetListAll();
        }

		public void TAdd(About t)
		{
			throw new System.NotImplementedException();
		}

		public void TDelete(About t)
		{
			throw new System.NotImplementedException();
		}

		public void TUpdate(About t)
		{
			throw new System.NotImplementedException();
		}
	}

}
