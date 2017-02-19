using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Match
    {
        public int ID { get; set; }
        [Required]
        public ApplicationUser Team { get; set; }
        public DateTime DateTime { get; set; }
        [Required, StringLength(255)]
        public string venue { get; set; }
        [Required]
        public League League { get; set; }
    }
    
    
}