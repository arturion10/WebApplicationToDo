using System.ComponentModel.DataAnnotations;

namespace WebApplicationTest.Models
{
    public class TaskToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime StartDateTime { get; } = DateTime.Now;
    }
}
