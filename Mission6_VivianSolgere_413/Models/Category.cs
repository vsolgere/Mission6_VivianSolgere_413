﻿using System.ComponentModel.DataAnnotations;

namespace Mission6_VivianSolgere_413.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        //public List<Movie> Movies { get; set; } 
    }
}
