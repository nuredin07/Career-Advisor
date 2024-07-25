using System.ComponentModel.DataAnnotations;

namespace Career_Advisor.Models
{
    public class Comment
    {
        [Key] 

        public int Numri { get; set; }
        public int Nr { get; set; }

        public String Emri { get; set; }

        
    }
}
