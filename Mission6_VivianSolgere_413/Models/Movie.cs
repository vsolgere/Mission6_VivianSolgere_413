namespace Mission6_VivianSolgere_413.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Movie
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1900, 2100)] // Adjust range as necessary
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool? Edited { get; set; }

        public string? LentTo { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
