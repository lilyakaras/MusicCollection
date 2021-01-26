using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    public class Discount
    {
        [Key]
        public int IdDiscount { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Percent { get; set; }
        [ForeignKey("IdDisk")]
        public Disk Disk { get; set; }
        public int IdDisk { get; set; }
        [Required]
        public DateTime DtStart { get; set; }
        [Required]
        public DateTime DtEnd { get; set; }
    }
}
