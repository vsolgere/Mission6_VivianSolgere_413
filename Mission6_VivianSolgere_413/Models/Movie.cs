using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_VivianSolgere_413.Models
{
    public partial class Movie
    {
        [Key]
        public int MovieId { get; set; }

        public int? CategoryId { get; set; } // Make sure this matches the database column name

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Enter a Title")]
        public string Title { get; set; } = null!;

        [Range(1888, 2025)]
        [Required(ErrorMessage = "Year Must Be Entered")]
        public int Year { get; set; } = 2024;
        public string? Director { get; set; }
        public string? Rating { get; set; }

        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required]
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }

    }
}
