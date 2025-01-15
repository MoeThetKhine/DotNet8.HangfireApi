using DotNet8.HangfireApi.Models;

namespace DotNet8.HangfireApi.Repositories.Blog
{
    public interface IBlogRepository
    {
        Task<BlogListResponseModel> GetBlogs();
        Task<int> CreateBlog(BlogRequestModel requestModel);
    }
}
