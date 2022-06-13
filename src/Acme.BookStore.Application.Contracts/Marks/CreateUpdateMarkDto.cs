using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Marks
{
    public class CreateUpdateMarkDto
    {
        [Required]
        public Guid StudentId { get; set; }
        [Required]
        public string ExamName { get; set; }
        [Required]
        public float Mark1 { get; set; }
        public float Mark2 { get; set; }
    }
}
