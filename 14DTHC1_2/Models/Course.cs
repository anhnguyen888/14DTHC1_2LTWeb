using System;
using System.ComponentModel.DataAnnotations;

namespace _14DTHC1_2.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser Lecturer { get; set; }

        [Required]
        public string LecturerId { get; set; }

        public Category Category { get; set; }

        [Required]
        public byte CategoryId { get; set; }

        public string Place { get; set; }

        public DateTime DateTime { get; set; }


    }
}