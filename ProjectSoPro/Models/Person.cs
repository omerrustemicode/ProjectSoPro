using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSoPro.Models
{
    public class Person
    {
        [Key]
        public int Personid { get; set; }
        [Required]
        [DisplayName("Name")]
        [StringLength(50, MinimumLength = 2)]
        public string name { get;set; }
        [Required]
        [DisplayName("Surname")]
        [StringLength(50, MinimumLength = 2)]
        public string surname { get; set; }
        [Required]
        [DisplayName("Email")]
        public string email { get; set; }
        [Required]
        [DisplayName("Password")]

        public string password { get; set; }

        public virtual ICollection<PersonRoles> PersonRoles { get; set; }

        public string FullName
        {
            get
            {
                return name + ", " + surname;
            }
        }
    }
}
