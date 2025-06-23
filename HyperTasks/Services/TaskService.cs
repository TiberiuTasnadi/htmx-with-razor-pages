using HyperTasks.Services.Contracts;

namespace HyperTasks.Services;

/// <summary>
/// Task Service class.
/// This interface should not be placed in the presentation layer.
/// In a real-world application, it would be implemented in the Application layer.
/// </summary>
public class TaskService : ITaskService
{
    private readonly List<Models.Task> _tasks = [];

    /// <inheritdoc/>
    public void Add(string description)
    {
        _tasks.Add(new Models.Task { Id = _tasks.Count + 1, Description = description });
    }

    /// <inheritdoc/>
    public List<Models.Task> GetAll() => _tasks;
}
