using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTourismClassLibrary.UserManagement
{
  public  class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Rank { get; set; }

        public ICollection<User> User { get; set; } = new HashSet<User>();
    }
}
