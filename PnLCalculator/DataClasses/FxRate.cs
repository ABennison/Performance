using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PnLCalculator.DataClasses
{
    [Table("FxRate")]
    [PrimaryKey(nameof(Date), nameof(CurrencyCode))]
    public class FxRate
    {
        [Column("Date", Order = 1)]
        public DateTime Date { get; set; }

        [Column("CurrencyCode", Order = 2)]
        [MaxLength(3)]
        public string CurrencyCode { get; set; }

        [Column("Rate")]
        [Precision(24, 8)]
        public decimal Rate { get; set; }
    }
}
