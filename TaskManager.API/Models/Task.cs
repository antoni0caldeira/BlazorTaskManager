using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.API.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        public int TaskStatusId { get; set; }
        public TaskStatus TaskStatus { get; set; }
        
        public int UserId { get; set; }

        public IEnumerable<Task> Tasks  { get; set; }
    }
}
