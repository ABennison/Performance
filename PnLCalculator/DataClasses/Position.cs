using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PnLCalculator.DataClasses
{
    [Table("Position")]
    [PrimaryKey(nameof(PositionDate), nameof(InstrumentID))]
    public class Position
    {
        [Key]
        [Column("PositionDate", Order = 1)]
        public DateTime PositionDate { get; set; }

        [Column("InstrumentID", Order = 2)]
        public int InstrumentID { get; set; }

        public decimal Quantity {  get; set; }

        public decimal MarketPriceLC { get; set; }

        public decimal NavLC { get; set; }

        public decimal PnlLC { get; set; }

        public decimal FxRate { get; set; }

        public decimal NavUSD { get; set;}

        public decimal PnlLC_USD { get; set; }

        public decimal PnlUSD { get; set; }

    }
}
