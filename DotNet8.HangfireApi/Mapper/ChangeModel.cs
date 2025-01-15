namespace DotNet8.HangfireApi.Mapper;

#region ChangeModel

public static class ChangeModel
{

    #region BlogModel Map 

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

    #endregion

    #region TblBlog Map

    public static TblBlog Map(this BlogRequestModel requestModel)
    {
        return new TblBlog
        {
            BlogTitle = requestModel.BlogTitle,
            BlogAuthor = requestModel.BlogAuthor,
            BlogContent = requestModel.BlogContent
        };
    }

    #endregion

}

#endregion
