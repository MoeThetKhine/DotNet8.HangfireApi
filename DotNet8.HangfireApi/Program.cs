var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddFeatures(builder);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseHangfireDashboard();

#region AddOrUpdate

RecurringJob.AddOrUpdate<IBlogRepository>(
    Guid.NewGuid().ToString(),
    x => x.CreateBlog(
        new BlogRequestModel() 
        { 
            BlogTitle = "Recurring Job", 
            BlogAuthor = "Recurring Job",
            BlogContent = "Recurring Job" 
        }),
    Cron.Minutely);

#endregion

#region Schedule

BackgroundJob.Schedule<IBlogRepository>(
       x => x.CreateBlog(new BlogRequestModel()
        {
            BlogTitle = "Delay Job", 
            BlogAuthor = "Delay Job",
            BlogContent = "Delay Job" 
        }),
          TimeSpan.FromMinutes(1));

#endregion

app.UseAuthorization();

app.MapControllers();

app.Run();
