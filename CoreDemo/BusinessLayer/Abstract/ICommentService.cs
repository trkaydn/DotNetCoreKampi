using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        List<Comment> GetList(int id);
		List<Comment> GetListWithBlog();

		//void DeleteComment(Comment comment);
		//void UpdateComment(Comment comment);
		//Comment GetById(int id);
	}
}
