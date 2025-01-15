namespace DotNet8.HangfireApi.Repositories.Blog
{
    public class BlogRepository : IBlogRepository
    {
        private readonly AppDbContext _appDbContext;

        public BlogRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<int> CreateBlog(BlogRequestModel requestModel)
        {
            try
            {
                await _appDbContext.TblBlogs.AddAsync(requestModel.Map());
                return await _appDbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<BlogListResponseModel> GetBlogs()
        {
            try
            {
                var lst = await _appDbContext.TblBlogs
                    .AsNoTracking()
                    .OrderByDescending(x => x.BlogId)
                    .ToListAsync();
                return new BlogListResponseModel()
                {
                    DataLst = lst.Select(x => x.Map()).ToList()
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
