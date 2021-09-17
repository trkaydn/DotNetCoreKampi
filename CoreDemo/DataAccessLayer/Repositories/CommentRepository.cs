using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories
{
    public class CommentRepository : IGenericDal<Comment>
    {
        public void Delete(Comment entity)
        {
            throw new System.NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Comment> GetList()
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Comment entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Comment entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
