using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSoPro.Models
{
    public class Movie
    {
        [Key]
        public int Movieid { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Title { get; set; }

        public virtual ICollection<MovieRoles> MovieRoles { get; set; }
        public virtual ICollection<PersonRoles> PersonRoles { get; set; }
    }
}
