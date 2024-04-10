using BlazorWebAssembly.Models;

namespace BlazorWebAssembly.Services
{
    public interface ITodoService
    {
        List<Todo> GetTodos();

        void AddTodo(Todo todo);

        void ToggleComplete(Guid id);

        void RemoveTodo(Guid id);
    }
}
