using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogdal;

        public BlogManager(IBlogDal blogdal)
        {
            _blogdal = blogdal;
        }

        public void AddBlog(Blog blog)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            throw new System.NotImplementedException();
        }

        public Blog GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Blog> GetList()
        {
            return _blogdal.GetList();
        }

        public void UpdateBlog(Blog blog)
        {
            throw new System.NotImplementedException();
        }
    }
}
