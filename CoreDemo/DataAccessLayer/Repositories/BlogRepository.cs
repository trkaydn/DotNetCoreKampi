
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog blog)
        {
            using (var c = new Context())
            {
                c.Add(blog);
                c.SaveChanges();
            }
        }

        public void Delete(Blog entity)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            using (var c = new Context())
            {
                c.Remove(blog);
                c.SaveChanges();
            }
        }

        public Blog GetById(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Find(id);
            }
        }

        public List<Blog> GetList()
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Blog entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Blog> ListAllBlog()
        {
            using (var c = new Context())
            {
                return c.Blogs.ToList();
            }
        }

        public void Update(Blog entity)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            using (var c = new Context())
            {
                c.Update(blog);
                c.SaveChanges();
            }
        }
    }
}
