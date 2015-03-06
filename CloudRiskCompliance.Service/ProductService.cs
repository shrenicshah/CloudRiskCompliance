using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CloudRiskCompliance.DataLayer.Context;
using CloudRiskCompliance.DomainClasses;
using CloudRiskCompliance.ServiceLayer.Contracts;
using CloudRiskCompliance.Logging;

namespace CloudRiskCompliance.ServiceLayer
{
    public class ProductService : IProductService
    {
        IUnitOfWork _uow;
        readonly IDbSet<Product> _products;
        private readonly ILogger _logger;

        public ProductService(IUnitOfWork uow, ILogger logger)
        {
            _uow = uow;
            _logger = logger;
            _products = _uow.Set<Product>();
        }

        public void AddNewProduct(Product product)
        {
            _products.Add(product);
        }

        public IList<Product> GetAllProducts()
        {
            _logger.Log("Getting all products");
            return _products.Include(x => x.Category).ToList();
        }
    }
}
