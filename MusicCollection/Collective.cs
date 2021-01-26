using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    public class Collective
    {
        [Key]
        public int IdCollective { get; set; }
        [Required]
        public string Name { get; set; }
        public override string ToString()
        {
            return IdCollective + ". " + Name;
        }
    }
}
