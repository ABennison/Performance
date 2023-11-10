using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PnLCalculator.DataClasses
{
    [Table("Currency")]
    public class Currency
    {
        [Key]
        [Column("Code")]
        [MaxLength(3)]
        public string Code { get; set; }

        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [NotMapped]
        public IEnumerable<Instrument> Instruments { get; set; } = new List<Instrument>();

        [NotMapped]
        public IEnumerable<FxRate> FxRates { get; set; } = new List<FxRate>();
    }
}
