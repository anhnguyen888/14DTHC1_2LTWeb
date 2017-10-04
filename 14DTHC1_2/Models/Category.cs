using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _14DTHC1_2.Models
{
    public class Category
    {
        public byte Id { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}