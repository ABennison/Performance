﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PnLCalculator.DataClasses
{
    [Table("Instrument")]
    public class Instrument
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Required]
        [Column("Ticker")]
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

        [NotMapped]
        public IEnumerable<Transaction> Transactions { get; set;  } = new List<Transaction>();

        [NotMapped]
        public Currency Currency { get; set; };
    }
}
