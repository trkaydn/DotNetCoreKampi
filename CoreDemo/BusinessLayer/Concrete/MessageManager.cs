using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
	public class MessageManager : IMessageService
	{
		IMessageDal _messageDal;

		public MessageManager(IMessageDal messageDal)
		{
			_messageDal = messageDal;
		}

		public Message GetById(int id)
		{
			return _messageDal.GetById(id);
		}

		public List<Message> GetList()
		{
			return _messageDal.GetListAll();
		}

		public List<Message> GetInboxListByWriter(string p)
		{
			return _messageDal.GetListAll(x => x.Receiver == p);
		}

		public void TAdd(Message t)
		{
			_messageDal.Insert(t);
		}

		public void TDelete(Message t)
		{
			_messageDal.Delete(t);
		}

		public void TUpdate(Message t)
		{
			_messageDal.Update(t);
		}
	}
}
