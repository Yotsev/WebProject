using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Infrastructure.Data.TvSeries
{
    public class Season
    {
        public Season()
        {
            this.Episodes= new List<Episode>();
        }

        [Required]
        public Guid Id { get; set; }

        [Required]
        [Range(1,1000)]
        public int Number { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        public virtual ICollection<Episode> Episodes { get; set; }
    }
}