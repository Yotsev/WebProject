using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Infrastructure.Data.TvSeries
{
    public class Episode
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Range(0, 5000)]
        public int Number { get; set; }

        [Required]
        [StringLength(215)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(2000)]
        public string Description { get; set; } = null!;

        public bool isWatched { get; set; } = false;

        [Required]
        public Guid SeasonId { get; set; }

        [ForeignKey(nameof(SeasonId))]
        public virtual Season Season { get; set; }
    }
}
