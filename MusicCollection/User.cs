using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        [MaxLength(20)]
        public string FirstName { get; set; }

        [MaxLength(20)]
        public string LastName { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
        [Required]
        public bool IsClient { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
