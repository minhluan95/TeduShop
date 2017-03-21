﻿using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;
using System.Linq;
namespace TeduShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int PageIndex, int PageSize, out int totalRow);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetAllByTag(string tag, int PageIndex, int PageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status
                        orderby p.CreatedDate descending
                        select p;
            totalRow = query.Count();
            query = query.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            return query;
        }
    }
}