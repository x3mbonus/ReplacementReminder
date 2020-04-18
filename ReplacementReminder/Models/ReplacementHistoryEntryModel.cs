using ReplacementReminder.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReplacementReminder.Models
{
    public class ReplacementHistoryEntryModel
    {
        public int Id { get; set; }

        public int ItemId { get; set; }
        
        [Required]
        public ReplacementItem Item { get; set; }

        [Required]
        public DateTime? ReplacementTime { get; set; }

        public States? State { get; set; }

        public string Comment { get; set; }

        public int PhotoId { get; set; }

        public Photo Photo { get; set; }

    }
}
