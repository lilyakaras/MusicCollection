using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    public class Disk
    {
        [Key]
        public int IdDisk { get; set; }
        [Required]
        public string Title { get; set; }
        [ForeignKey("IdCollective")]
        public Collective Collective { get; set; }
        public int IdCollective { get; set; }
        [ForeignKey("IdPublisher")]
        public Publisher Publisher { get; set; }
        public int IdPublisher { get; set; }
        [Required]
        public int CountSongs { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        [Required]
        public DateTime DtPublish { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Cost { get; set; }
        [Required]
        public double SellingPrice { get; set; }
        [Required]
        public bool IsWriteOff { get; set; }
        public Disk()
        {
            Genres = new List<Genre>();
        }
        public override string ToString()
        {
            return IdDisk + ". " + Title;
        }
    }
}
