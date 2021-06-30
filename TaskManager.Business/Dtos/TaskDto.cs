using System;
using TaskManagerDAL.Models;

namespace TaskManager.Business.Dtos
{
    class TaskDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset EndDate { get; set; }

        public TaskStatus Status { get; set; }

        public int UserId { get; set; }
    }
}
