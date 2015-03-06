using System.Collections.Generic;
using CloudRiskCompliance.DomainClasses;

namespace CloudRiskCompliance.ServiceLayer.Contracts
{
    public interface IProductService
    {
        void AddNewProduct(Product product);
        IList<Product> GetAllProducts();
    }
}