namespace DotNet8.HangfireApi.Repositories.Blog;

#region IBlogRepository

public interface IBlogRepository
{
    Task<BlogListResponseModel> GetBlogs();
    Task<int> CreateBlog(BlogRequestModel requestModel);
}

#endregion