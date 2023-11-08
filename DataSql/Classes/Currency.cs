using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataSql.Classes
{
    [Table("Currency")]
    public class Currency
    {
        [Key]
        [Column("CurrencyCode")]
        [MaxLength(3)]
        public string CurrencyCode { get; set; }

        [Required]
        [Column("CurrencyName")]
        [MaxLength(100)]
        public string CurrencyName { get; set; }
    }
}
