using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReplacementReminder.Data
{
    public class ReplacementHistoryEntry
    {
        [Key]
        public int Id { get; set; }

        public int ItemId { get; set; }
        
        [ForeignKey("ReplacementActionItemId_ReplacementItemId")]
        public ReplacementItem Item { get; set; }

        public DateTime? ReplacementTime { get; set; }

        public States? State { get; set; }

        public string Comment { get; set; }

        public int PhotoId { get; set; }

        [ForeignKey("ReplacementActionPhotoId_PhotoId")]
        public Photo Photo { get; set; }

    }
}
