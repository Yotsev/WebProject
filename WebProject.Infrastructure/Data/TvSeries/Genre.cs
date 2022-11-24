using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Infrastructure.Data.TvSeries
{
    public class Genre
    {
        public Genre()
        {
            this.SeriesGenres = new List<GenreSeries>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        public virtual ICollection<GenreSeries> SeriesGenres { get; set; }
    }
}
