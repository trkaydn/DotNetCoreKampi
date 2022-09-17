using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;


namespace BusinessLayer.Concrete
{
	public class AdminManager : IAdminService
	{
		IAdminDal _adminDal;

		public AdminManager(IAdminDal adminDal)
		{
			_adminDal = adminDal;
		}

		public Admin GetById(int id)
		{
			return _adminDal.GetById(id);
		}

		public List<Admin> GetList()
		{
			return _adminDal.GetListAll();
		}

		public void TAdd(Admin t)
		{
			_adminDal.Insert(t);
		}

		public void TDelete(Admin t)
		{
			_adminDal.Delete(t);
		}

		public void TUpdate(Admin t)
		{
			_adminDal.Update(t);
		}
	}
}
