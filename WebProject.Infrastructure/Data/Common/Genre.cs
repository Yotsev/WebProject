using System.ComponentModel.DataAnnotations;
using WebProject.Infrastructure.Data.TvSeries;

namespace WebProject.Infrastructure.Data.Common
{
    public class Genre
    {
        public Genre()
        {
            this.Series = new List<Series>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        public ICollection<Series> Series { get; set; }
    }
}
