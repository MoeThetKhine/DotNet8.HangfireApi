using DotNet8.HangfireApi.Models;
using DotNet8.HangfireApi.Repositories.Blog;

namespace DotNet8.HangfireApi.Features.Blog
{
    public class BL_Blog
    {
        private readonly IBlogRepository _blogRepository;

        public BL_Blog(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<BlogListResponseModel> GetBlogs()
        {
            return await _blogRepository.GetBlogs();
        }
    }
}
