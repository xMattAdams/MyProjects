using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListWebApi.Models
{
    public class ToDo
    {
        [Key]
        public int ToDoId { get; set; }

        public string Content { get; set; }

        public bool isDone { get; set; }

        public bool isOutdated { get; set; }

        public DateTime Deadline { get; set; }
    }
}
