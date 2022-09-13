﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
	public class NotificationManager : INotificationService
	{
		INotificationDal _notificationDal;

		public NotificationManager(INotificationDal notificationDal)
		{
			_notificationDal = notificationDal;
		}

		public Notification GetById(int id)
		{
			return _notificationDal.GetById(id);
		}

		public List<Notification> GetList()
		{
			return _notificationDal.GetListAll();
		}

		public void TAdd(Notification t)
		{
			_notificationDal.Insert(t);
		}

		public void TDelete(Notification t)
		{
			_notificationDal.Delete(t);
		}

		public void TUpdate(Notification t)
		{
			_notificationDal.Update(t);
		}
	}
}