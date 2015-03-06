using System.Collections.Generic;
using CloudRiskCompliance.DomainClasses;

namespace CloudRiskCompliance.ServiceLayer.Contracts
{
    public interface ICategoryService
    {
        void AddNewCategory(Category category);
        IList<Category> GetAllCategories();
    }
}