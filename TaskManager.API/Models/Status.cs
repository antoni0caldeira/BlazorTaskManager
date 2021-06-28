﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.API.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public IEnumerable<Status> Statues { get; set; }
    }
}
