using System.ComponentModel.DataAnnotations;

namespace ReplacementReminder.Models
{
    public class PhotoModel
    {
        public int Id { get; set; }

        public string PhotoFileName { get; set; }

        public string PhotoBlob { get; set; }
    }
}
