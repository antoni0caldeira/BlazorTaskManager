using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskManagerDAL.Models
{
    public class TaskStatus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Models.Task> Tasks { get; set; }
    }
}
