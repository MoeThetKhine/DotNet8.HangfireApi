namespace DotNet8.HangfireApi.Modelts;

public partial class TaskCategory
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public bool? IsDelete { get; set; }

    public virtual ICollection<ToDoList> ToDoLists { get; set; } = new List<ToDoList>();
}
