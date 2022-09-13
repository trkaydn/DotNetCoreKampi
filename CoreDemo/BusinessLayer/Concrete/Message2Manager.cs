using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
	public class Message2Manager : IMessage2Service
	{
		IMessage2Dal _message2Dal;

		public Message2Manager(IMessage2Dal message2Dal)
		{
			_message2Dal = message2Dal;
		}

		public Message2 GetById(int id)
		{
			return _message2Dal.GetById(id);
		}

		public List<Message2> GetInboxListByWriter(int id)
		{
			return _message2Dal.GetListWithMessageByWriter(id);
		}

		public List<Message2> GetList()
		{
			return _message2Dal.GetListAll();
		}

		public void TAdd(Message2 t)
		{
			_message2Dal.Insert(t);
		}

		public void TDelete(Message2 t)
		{
			_message2Dal.Delete(t);
		}

		public void TUpdate(Message2 t)
		{
			_message2Dal.Update(t);
		}
	}
}
