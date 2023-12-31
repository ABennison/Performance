﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PnLCalculator.DataClasses
{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Required]
        [Column("InstrumentID")]
        public int InstrumentID { get; set; }

        [Required]
        [Column("TradeDate")]
        public DateTime TradeDate { get; set; }

        [Required]
        [Column("Quantity")]
        public decimal Quantity { get; set; }

        [Required]
        [Column("TradePrice")]
        public decimal TradePrice { get; set; }
    }
}
