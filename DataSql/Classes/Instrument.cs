using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSql.Classes
{
    [Table("Instrument")]
    public class Instrument
    {
        [Key]
        [StringLength(255)]
        public string Identifier { get; set; }

        [StringLength(255)]
        public string InstrumentType { get; set; }
    }
}
