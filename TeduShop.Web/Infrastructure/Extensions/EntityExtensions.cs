using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryVm)
        {
            postCategory.ID = postCategoryVm.ID;

            postCategory.Name = postCategoryVm.Name;

            postCategory.Description = postCategoryVm.Description;

            postCategory.Alias = postCategoryVm.Alias;

            postCategory.ParentID = postCategoryVm.ParentID;

            postCategory.DisplayOrder = postCategoryVm.DisplayOrder;

            postCategory.Image = postCategoryVm.Image;

            postCategory.CreatedBy = postCategoryVm.CreatedBy;

            postCategory.CreatedDate = postCategoryVm.CreatedDate;

            postCategory.UpdatedBy = postCategoryVm.UpdatedBy;

            postCategory.UpdatedDate = postCategoryVm.UpdatedDate;

            postCategory.MetaDescription = postCategoryVm.MetaDescription;

            postCategory.MetaKeyword = postCategoryVm.MetaKeyword;
        }

        public static void UpdateProductCategory(this ProductCategory productCategory, ProductCategoryViewModel productCategoryVm)
        {
            productCategory.ID = productCategoryVm.ID;

            productCategory.Name = productCategoryVm.Name;

            productCategory.Description = productCategoryVm.Description;

            productCategory.Alias = productCategoryVm.Alias;

            productCategory.ParentID = productCategoryVm.ParentID;

            productCategory.DisplayOrder = productCategoryVm.DisplayOrder;

            productCategory.Image = productCategoryVm.Image;

            productCategory.CreatedBy = productCategoryVm.CreatedBy;

            productCategory.CreatedDate = productCategoryVm.CreatedDate;

            productCategory.UpdatedBy = productCategoryVm.UpdatedBy;

            productCategory.UpdatedDate = productCategoryVm.UpdatedDate;

            productCategory.MetaDescription = productCategoryVm.MetaDescription;

            productCategory.MetaKeyword = productCategoryVm.MetaKeyword;
        }

        public static void UpdatePost(this Post post, PostViewModel postVm)
        {
            post.ID = postVm.ID;

            post.Name = postVm.Name;

            post.CategoryID = postVm.CategoryID;

            post.Alias = postVm.Alias;

            post.Image = postVm.Image;

            post.Description = postVm.Description;

            post.Content = postVm.Content;

            post.HotFlag = postVm.HotFlag;

            post.ViewCount = postVm.ViewCount;

            post.CreatedBy = postVm.CreatedBy;

            post.CreatedDate = postVm.CreatedDate;

            post.UpdatedBy = postVm.UpdatedBy;

            post.UpdatedDate = postVm.UpdatedDate;

            post.MetaDescription = postVm.MetaDescription;

            post.MetaKeyword = postVm.MetaKeyword;
        }
    }
}