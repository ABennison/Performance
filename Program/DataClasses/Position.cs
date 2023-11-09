using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PnLCalculator.Classes
{
    [Table("Position")]
    [PrimaryKey(nameof(Date), nameof(InstrumentIdentifier))]
    public class Position
    {
        [Key]
        [Column("Date", Order = 1)]
        public DateTime Date { get; set; }

        [Required]
        [Column("InstrumentIdentifier", Order = 2)]
        [MaxLength()]
        public string InstrumentIdentifier { get; set; }

        [Column("Amount")]
        [Precision(24, 8)]
        public decimal? Amount { get; set; }
    }
}
