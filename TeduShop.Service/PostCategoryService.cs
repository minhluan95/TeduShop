using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IPostCategoryService
    {
        ProductCategory Add(ProductCategory PostCategory);

        void Update(ProductCategory PostCategory);

        ProductCategory Delete(int id);

        IEnumerable<ProductCategory> GetAll();

        IEnumerable<ProductCategory> GetAllByParentId(int ParentId);

        ProductCategory GetById(int id);

        void Save();
    }

    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRepository _postCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public ProductCategory Add(ProductCategory PostCategory)
        {
            return _postCategoryRepository.Add(PostCategory);
        }

        public ProductCategory Delete(int id)
        {
            return _postCategoryRepository.Delete(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public IEnumerable<ProductCategory> GetAllByParentId(int ParentId)
        {
            return _postCategoryRepository.GetMulti(x => x.Status && x.ParentID == ParentId);
        }

        public ProductCategory GetById(int id)
        {
            return _postCategoryRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductCategory PostCategory)
        {
            _postCategoryRepository.Update(PostCategory);
        }
    }
}