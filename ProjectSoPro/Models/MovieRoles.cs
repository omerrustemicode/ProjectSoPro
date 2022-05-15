using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectSoPro.Models
{
    public class MovieRoles
    {
        [Key]
        public int MovieRolesId { get; set; }
        [Display(Name = "genreId")]
        [Column("GenreId")]
        public int genreId { get; set; }
        [ForeignKey("genreId")]
        public virtual Genre Genre { get; set; }
        [Display(Name = "Movie")]
        [Column("Movieid")]
        public int Movieid { get; set; }
        [ForeignKey("Movieid")]
        public virtual Movie Movie { get; set; }
    }
}
