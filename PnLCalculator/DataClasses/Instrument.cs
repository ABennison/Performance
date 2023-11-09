using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PnLCalculator.Classes
{
    [Table("Instrument")]
    public class Instrument
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [MaxLength(255)]
        public string Ticker { get; set; }

        [Required]
        [Column("Type")]
        [MaxLength(50)]
        public string InstrumentType { get; set; }

        [Required]
        [Column("LocalCurrency")]
        [MaxLength(3)]
        public string LocalCurrency { get; set; }
    }
}
