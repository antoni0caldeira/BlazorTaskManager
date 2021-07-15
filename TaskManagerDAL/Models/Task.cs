using System;
using System.ComponentModel.DataAnnotations;

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
        public DateTimeOffset StartDate { get; set; }

        [Required]
        public DateTimeOffset EndDate { get; set; }

        [Required]
        public TaskStatus Status { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}
