using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    public class ReserveDisks
    {
        public int Id { get; set; }
        [ForeignKey("IdDisk")]
        public Disk Disk { get; set; }
        public int IdDisk { get; set; }

        [ForeignKey("IdUser")]
        public User User { get; set; }
        public int IdUser { get; set; }

    }
}
