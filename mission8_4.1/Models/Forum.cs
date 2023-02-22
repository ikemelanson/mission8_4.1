using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission8_4._1.Models
{
    public class Forum
    {
        [Key]
        [Required]
        public int TaskId { get; set; }
        [Required]
        public string Task { get; set; }
        public int DueDate { get; set; }
        [Required]
        public string Quadrant { get; set; }
        public bool Completed { get; set; }

        //Building foreign key relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

