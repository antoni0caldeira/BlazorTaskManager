using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerDAL.Models
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
        public DateTimeOffset StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTimeOffset EndDate { get; set; }

        [Required]
        public int TaskStatusId { get; set; }
        
        [Required]
        public TaskStatus TaskStatus { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}
