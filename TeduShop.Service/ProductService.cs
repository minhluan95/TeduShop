using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IProductService
    {
        void Add(Product Product);
        void Update(Product product);
        void Delete(int id);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow);
        IEnumerable<Product> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);
        IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        Product GetById(int id);
        void SaveChanges();
    }
    public class ProductService : IProductService
    {
        ProductRepository _productRepository;
        UnitOfWork _unitOfWork;
        public ProductService(ProductRepository productRepository, UnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Product Product)
        {
            _productRepository.Add(Product);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll(new string[] { "ProductCategory" });
        }

        public IEnumerable<Product> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetMultiPaging(x => x.Status && x.CategoryID == categoryId, out totalRow, page, pageSize, new string[] { "PostCategory" });
        }

        public IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //TODO: Select all post by tag
            return _productRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Product GetById(int id)
        {
            return _productRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}
