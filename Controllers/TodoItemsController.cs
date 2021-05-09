using GenericCrudApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenericCrudApi.Controllers
{
    public class TodoItemsController : CrudControllerBase<TodoItem>
    {
        public TodoItemsController(DataContext context) : base(context)
        { }
    }
}