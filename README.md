
# HyperTasks

**HyperTasks** is a simple but expressive demo built with **ASP.NET Core Razor Pages** and **htmx**, showcasing how to build interactive web applications using hypermedia principles — without relying on JavaScript frameworks or JSON-based APIs.

---

## 📸 Preview

![Screenshot of the final result](./img/htmx.PNG)

---

## ✨ Features

- Interactive task list with dynamic add functionality
- Edit tasks in-place with dynamic form swapping
- Delete tasks with confirmation dialogs
- Built using Razor Pages (Server-Side Rendering)
- Uses [htmx](https://htmx.org) for partial updates via `GET` and `POST`
- No JavaScript frameworks required
- Styled with Bootstrap (locally installed)

---

## 🔧 Technologies

- .NET 8 Razor Pages
- htmx 1.9.2 (local)
- Bootstrap 5 (local)
- HTML partial rendering
- Minimal C#, no async (in-memory storage)

---

## 🚀 Getting Started

1. Clone the repository:

2. Run the project:

```bash
dotnet run
```

3. Navigate to:

```
https://localhost:PORT/
```

---

## 📁 Project Structure

```bash
├── Models/
│   └── Tarea.cs
├── Services/
│   └── TaskService.cs
├── Pages/
│   ├── Tasks.cshtml
│   ├── Tasks.cshtml.cs
│   └── Shared/
│       ├── _TaskList.cshtml
│       └── _TaskEditForm.cshtml
├── wwwroot/
│   ├── js/htmx.min.js
│   ├── js/bootstrap.bundle.min.js
│   └── css/bootstrap.min.css
```

---

## 🧩 Core HTML (Page: `Tasks.cshtml`)

![HTML Razor markup](./img/htmx2.PNG)

- Uses `hx-get`, `hx-post`, `hx-target`, and `hx-swap`
- Triggers on page load, form submit, and button clicks
- Styled with Bootstrap classes

---

## 🎯 Handlers (`Tasks.cshtml.cs`)

![OnGet / OnPost handlers](./img/htmx3.PNG)

- `OnGetList()` returns the rendered task list
- `OnPostAdd()` adds a new task
- `OnPostDelete()` deletes an existing task
- `OnGetEditForm()` shows inline edit form
- `OnPostEdit()` saves updated task data

---

## 🧱 Partials

### `_TaskList.cshtml`

Renders tasks using Bootstrap with edit/delete buttons:

![Partial view source code](./img/htmx5.PNG)

### `_TaskEditForm.cshtml`

Inline edit form rendered dynamically:

![Partial edit form code](./img/htmx6.PNG)

---

## 📚 Learning Goals

This project demonstrates:

- How hypermedia concepts apply to web UI
- How htmx allows server-driven UI updates
- How Razor Pages enable SSR with minimal setup
- How to avoid overengineering with JS frameworks
- How to implement in-place editing with HTML partials and handlers

---

## 📄 License

MIT
