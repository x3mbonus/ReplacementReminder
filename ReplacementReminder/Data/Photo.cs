using System.ComponentModel.DataAnnotations;

namespace ReplacementReminder.Data
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }

        public string PhotoFileName { get; set; }

        public string PhotoBlob { get; set; }
    }
}
