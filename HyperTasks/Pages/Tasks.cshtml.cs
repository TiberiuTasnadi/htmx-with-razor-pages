using HyperTasks.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HyperTasks.Pages;

/// <summary>
/// TasksModel class for managing tasks in the Razor Pages application.
/// </summary>
public class TasksModel : PageModel
{
    private readonly ITaskService _taskService;

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
}