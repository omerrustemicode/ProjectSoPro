using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectSoPro.Models
{
    public class PersonRoles
    {
        [Key]
        public int RolesId { get; set; }
        [DisplayName("Actors")]
        [Column("Actors")]
        public string? actors { get; set; }
        [Column("Directors")]
        [DisplayName("Directors")]
        public string? directors { get; set; }
        [Column("Producers")]
        [DisplayName("Producers")]
        public string? producers { get; set; }
        [Display(Name = "Movie")] 
        public int Movieid { get; set; }
        [ForeignKey("Movieid")]
        public virtual Movie Movie { get; set; }
        [Display(Name = "Person")]
        public int Personid { get; set; }
        [ForeignKey("Personid")]
        public virtual Person Person { get; set; }


    }
}
