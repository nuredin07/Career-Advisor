using System.ComponentModel.DataAnnotations;

namespace Career_Advisor.Models
{
    public class Career
    {
        [Key]
        public int Nr { get; set; }
        public String Emri { get; set; }

        public int MyProperty { get; set; }
    }
}
