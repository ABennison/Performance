using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataSql.Classes
{
    [Table("InstrumentType")]
    public class InstrumentType
    {
        [Key]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
