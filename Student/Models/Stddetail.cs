﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Student.Models
{
    public class Stddetail
    {
        [Key]
        public int Id {get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int phonenum { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public string? city { get; set; }

    }
}
