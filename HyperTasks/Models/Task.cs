namespace HyperTasks.Models;

/// <summary>
/// Task Model.
/// </summary>
public class Task
{
    /// <summary>
    /// Gets or sets the unique identifier for the task.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the description of the task.
    /// </summary>
    public string Description { get; set; } = string.Empty;
}