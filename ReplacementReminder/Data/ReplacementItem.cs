using System.ComponentModel.DataAnnotations;

namespace ReplacementReminder.Data
{
    public class ReplacementItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int TimeToExpire { get; set; }
    }
}
