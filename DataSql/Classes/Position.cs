using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSql.Classes
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
