using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PnLCalculator.Classes
{
    [Table("Instrument")]
    public class Instrument
    {
        [Key]
        [Column("InstrumentIdentifier")]
        [MaxLength(255)]
        public string InstrumentIdentifier { get; set; }

        [Required]
        [Column("InstrumentType")]
        [MaxLength(255)]
        public string InstrumentType { get; set; }

        [Required]
        [Column("LocalCurrencyCode")]
        [MaxLength(3)]
        public string LocalCurrencyCode { get; set; }
    }
}
