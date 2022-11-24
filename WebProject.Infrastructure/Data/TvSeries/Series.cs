using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Infrastructure.Data.TvSeries
{
    public class Series
    {
        public Series()
        {
            this.Seasons = new List<Season>();
            this.SeriesUsers = new List<UserSeries>();
            this.GenresSeries = new List<GenreSeries>();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(215)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(2000)]
        public string Description { get; set; } = null!;

        [StringLength(2048)]
        public string? ImageUrl { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        public bool isActive { get; set; } = true;

        [Required]
        public Guid DirectorId { get; set; }

        [ForeignKey(nameof(DirectorId))]
        public virtual Director Director { get; set; }

        public virtual ICollection<Season> Seasons { get; set; }

        public virtual ICollection<UserSeries> SeriesUsers { get; set; }

        public virtual ICollection<GenreSeries> GenresSeries { get; set; }
    }
}
