using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    public class Publisher
    {
        [Key]
        public int IdPublisher { get; set; }
        [Required]
        public string Name { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return IdPublisher + ". " + Name;
        }
    }
}
