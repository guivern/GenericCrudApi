namespace GenericCrudApi.Models
{
    public class TodoItem: EntityBase
    {
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}