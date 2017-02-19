using System;

namespace WebApplication1.Models
{
    public class Match
    {
        public int ID { get; set; }
        public ApplicationUser Team { get; set; }
        public DateTime DateTime { get; set; }
        public string venue { get; set; }
        public League League { get; set; }
    }
    
    
}