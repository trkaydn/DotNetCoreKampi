﻿using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void AddCategory(Category category)
        {
            efCategoryRepository.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public Category GetById(int id)
        {
            return efCategoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepository.GetList();
        }

        public void UpdateCategory(Category category)
        {
            efCategoryRepository.Update(category);
        }
    }
}
