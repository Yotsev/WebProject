using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Infrastructure.Data.TvSeries
{
    public class Director
    {
        public Director()
        {
            this.Series = new List<Series>();
        }
        
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(2000)]
        public string Description { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public virtual ICollection<Series> Series { get; set; }
    }
}
