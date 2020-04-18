using System.ComponentModel.DataAnnotations;

namespace ReplacementReminder.Models
{
    public class ReplacementItemModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int TimeToExpire { get; set; }
    }
}
