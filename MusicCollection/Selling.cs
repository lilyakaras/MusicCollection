using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    public class Selling
    {

        [Key]
        public int IdSell { get; set; }
        [ForeignKey("IdDisk")]
        public Disk Disk { get; set; }
        public int IdDisk { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public DateTime DateSell { get; set; }
        [ForeignKey("IdUser")]
        public User User { get; set; }
        public int IdUser { get; set; }
    }
}
