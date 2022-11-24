using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.Infrastructure.Data.Identity;

namespace WebProject.Infrastructure.Data.TvSeries
{
    public class UserSeries
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }

        [Required]
        public Guid SeriesId { get; set; }

        [ForeignKey(nameof(SeriesId))]
        public Series Series { get; set; }
    }
}
