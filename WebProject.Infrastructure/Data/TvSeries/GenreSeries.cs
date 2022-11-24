using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.Infrastructure.Data.Common;

namespace WebProject.Infrastructure.Data.TvSeries
{
    public class GenreSeries
    {
        [Required]
        public Guid SeriesId { get; set; }

        [ForeignKey(nameof(SeriesId))]
        public virtual Series Series { get; set;}

        [Required]
        public int GenreId { get; set; }

        [ForeignKey(nameof(GenreId))]
        public virtual Genre Genre { get; set; }
    }
}
