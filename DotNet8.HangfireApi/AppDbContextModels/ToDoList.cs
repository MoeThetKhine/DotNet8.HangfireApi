namespace DotNet8.HangfireApi.Modelts;

#region ToDoList

public partial class ToDoList
{
    public int TaskId { get; set; }

    public string TaskTitle { get; set; } = null!;

    public string? TaskDescription { get; set; }

    public int? CategoryId { get; set; }

    public byte? PriorityLevel { get; set; }

    public string? Status { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? CompletedDate { get; set; }

    public virtual TaskCategory? Category { get; set; }
}

#endregion