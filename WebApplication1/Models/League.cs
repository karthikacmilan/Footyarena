using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class League
    {
        
            public byte ID { get; set; }
            [Required, StringLength(255)]
            public string name { get; set; }
        
    }
}