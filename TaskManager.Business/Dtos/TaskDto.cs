using System;
using System.ComponentModel.DataAnnotations;
using TaskManagerDAL.Models;

namespace TaskManager.Business.Dtos
{
    public class TaskDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please insert a Title")]
        [StringLength(30, ErrorMessage = "Title length can't exceed 30 characters.")]
        public string Title { get; set; }

        [StringLength(200, ErrorMessage = "Description length can't exceed 200 characters.")]
        public string Description { get; set; }

        [Required] 
        public DateTimeOffset StartDate { get; set; }

        [Required]
        public DateTimeOffset EndDate { get; set; }

        [Required]
        public TaskStatusDto Status { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}
