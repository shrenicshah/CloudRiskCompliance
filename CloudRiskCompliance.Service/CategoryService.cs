using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CloudRiskCompliance.DataLayer.Context;
using CloudRiskCompliance.DomainClasses;
using CloudRiskCompliance.ServiceLayer.Contracts;

namespace CloudRiskCompliance.ServiceLayer
{
    public class CategoryService : ICategoryService
    {
        IUnitOfWork _uow;
        readonly IDbSet<Category> _categories;
        public CategoryService(IUnitOfWork uow)
        {
            _uow = uow;
            _categories = _uow.Set<Category>();
        }

        public void AddNewCategory(Category category)
        {
           _categories.Add(category);
        }

        public IList<Category> GetAllCategories()
        {
            return _categories.ToList();
        }
    }
}
