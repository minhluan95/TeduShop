using AutoMapper;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Mapping
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();

            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();

            Mapper.CreateMap<ProductCategory, ProductCategoryViewModel>();

            Mapper.CreateMap<ProductTag, ProductTagViewModel>();

            Mapper.CreateMap<Tag, TagViewModel>();

            Mapper.CreateMap<Product, ProductViewModel>();
        }
    }
}