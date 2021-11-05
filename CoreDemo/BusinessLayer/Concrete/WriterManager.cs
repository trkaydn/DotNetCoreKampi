using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		IWriterDal _writerdal;
		public WriterManager(IWriterDal writerdal)
		{
			_writerdal = writerdal;
		}

		public Writer GetById(int id)
		{
			return _writerdal.GetById(id);
		}

		public List<Writer> GetList()
		{
			return _writerdal.GetListAll();
		}

		public List<Writer> GetWritersById(int id)
		{
			return _writerdal.GetListAll(x => x.WriterID == id);
		}

		public void TAdd(Writer t)
		{
			_writerdal.Insert(t);
		}

		public void TDelete(Writer t)
		{
			_writerdal.Delete(t);
		}

		public void TUpdate(Writer t)
		{
			_writerdal.Update(t);
		}
	}
}
