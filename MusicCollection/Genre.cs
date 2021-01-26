using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    public class Genre
    {
        [Key]
        public int IdGenre { get; set; }
        [Required]
        [MinLength(3), MaxLength(20)]
        public string Title { get; set; }
        public virtual ICollection<Disk> Disks { get; set; }
        public Genre()
        {
            Disks = new List<Disk>();
        }
        public override string ToString()
        {
            return IdGenre + ". " + Title;
        }
    }
}
