﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSql.Classes
{
    [Table("InstrumentType")]
    public class InstrumentType
    {
        [Key]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
