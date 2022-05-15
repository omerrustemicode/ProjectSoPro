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
    public class Genre
    {
        [Key]
        public int genreId { get; set; }
      
        [DisplayName("Genres")]
        public string genres { get; set; }
 
        public virtual ICollection<MovieRoles> MovieRoles { get; set; }


    }
}
