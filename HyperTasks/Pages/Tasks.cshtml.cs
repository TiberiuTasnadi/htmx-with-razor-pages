using HyperTasks.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading;

namespace HyperTasks.Pages;

/// <summary>
/// TasksModel class for managing tasks in the Razor Pages application.
/// </summary>
public class TasksModel : PageModel
{
    private readonly ITaskService _taskService;

    [BindProperty]
    public Models.Task TaskEdit { get; set; } = new();

    public TasksModel(ITaskService taskService)
    {
        _taskService = taskService;
    }

    public IActionResult OnGetList()
    {
        var tasks = _taskService.GetAll();
        return Partial("_TaskList", tasks);
    }

    public IActionResult OnPostAdd(string description)
    {
        _taskService.Add(description);
        var tasks = _taskService.GetAll();
        return Partial("_TaskList", tasks);
    }

    public IActionResult OnPostDelete(int id)
    {
        _taskService.Remove(id);
        var tasks = _taskService.GetAll();
        return Partial("_TaskList", tasks);
    }

    public IActionResult OnGetEditForm(int id)
    {
        var task = _taskService.GetAll().FirstOrDefault(t => t.Id == id);
        if (task is null) return NotFound();

        return Partial("_TaskEditForm", task);
    }

    public IActionResult OnPostEdit()
    {
        var task = _taskService.GetAll().FirstOrDefault(t => t.Id == TaskEdit.Id);
        if (task is not null)
        {
            task.Description = TaskEdit.Description;
        }

        var tasks = _taskService.GetAll();
        return Partial("_TaskList", tasks);
    }
}