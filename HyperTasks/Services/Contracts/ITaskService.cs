using System.Threading;

namespace HyperTasks.Services.Contracts;

/// <summary>
/// Task Service Interface.
/// This interface should not be placed in the presentation layer.
/// In a real-world application, it would be implemented in the Application layer.
/// </summary>
public interface ITaskService
{
    /// <summary>
    /// Retrieves all tasks.
    /// </summary>
    /// <returns>A list of tasks.</returns>
    public List<Models.Task> GetAll();

    /// <summary>
    /// Adds a new task with the specified description.
    /// </summary>
    /// <param name="description">The task description.</param>
    public void Add(string description);

    /// <summary>
    /// Removes a task by its unique identifier.
    /// </summary>
    /// <param name="id">The id of the task to remove.</param>
    public void Remove(int id);
}
