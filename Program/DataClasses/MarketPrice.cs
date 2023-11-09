using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PnLCalculator.Classes
{
    [Table("MarketPrice")]
    [PrimaryKey(nameof(Date), nameof(InstrumentIdentifier))]
    public class MarketPrice
    {
        [Key]
        [Column("Date", Order = 1)]
        public DateTime Date { get; set; }

        [Required]
        [Column("InstrumentIdentifier", Order = 2)]
        [MaxLength()]
        public string InstrumentIdentifier { get; set; }

        [Column("Price")]
        [Precision(24, 8)]
        public decimal? Price { get; set; }
    }
}
