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
    }
}
