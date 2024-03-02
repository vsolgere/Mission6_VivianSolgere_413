namespace Mission6_VivianSolgere_413.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Movie
    {
        [Key]
        public int MovieId { get; set; }


        [ForeignKey("CategoryID")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }



        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1900, 2100)] // Adjust range as necessary
        public int Year { get; set; } = 2024;
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        public bool CopiedToPlex { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
