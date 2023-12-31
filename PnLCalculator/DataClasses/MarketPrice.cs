﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace PnLCalculator.DataClasses
{
    [Table("MarketPrice")]
    [PrimaryKey(nameof(PriceDate), nameof(InstrumentID))]
    public class MarketPrice
    {
        [Column("PriceDate", Order = 1)]
        public DateTime PriceDate { get; set; }

        [Column("InstrumentID", Order = 2)]
        public int InstrumentID { get; set; }

        [Column("Price")]
        [Precision(24, 8)]
        public decimal Price { get; set; }
    }
}
