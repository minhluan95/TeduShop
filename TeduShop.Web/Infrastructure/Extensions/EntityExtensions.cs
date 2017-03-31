using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this ProductCategory postCategory, PostCategoryViewModel postCategoryVm)
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