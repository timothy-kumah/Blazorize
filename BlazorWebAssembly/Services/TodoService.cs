using BlazorWebAssembly.Models;

namespace BlazorWebAssembly.Services
{
    public class TodoService : ITodoService
    {
        private List<Todo> todos = new List<Todo>();

        public void AddTodo(Todo todo)
        {
            todos.Add(todo);
        }

        public List<Todo> GetTodos()
        {
            return todos;
        }

        public void RemoveTodo(Guid id)
        {
            Todo todo = todos.FirstOrDefault(todo => todo.Id == id);
            todos.Remove(todo);
        }

        public void ToggleComplete(Guid id)
        {
            Todo todo = todos.FirstOrDefault(todo => todo.Id == id);
            todo.IsDone = !todo.IsDone;
        }
    }
}
