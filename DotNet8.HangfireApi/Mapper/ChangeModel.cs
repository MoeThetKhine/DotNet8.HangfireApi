﻿using DotNet8.HangfireApi.Features.Blog;
using DotNet8.HangfireApi.Models;
using DotNet8.HangfireApi.Modelts;

namespace DotNet8.HangfireApi.Mapper
{
    public static class ChangeModel
    {
        public static BlogModel Map(this TblBlog dataModel)
        {
            return new BlogModel
            {
                BlogId = dataModel.BlogId,
                BlogTitle = dataModel.BlogTitle,
                BlogAuthor = dataModel.BlogAuthor,
                BlogContent = dataModel.BlogContent
            };
        }
    }
}
