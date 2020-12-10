using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BestClothes.Model
{
    [Table("Customers", Schema = "recruit")]
    public partial class Customer
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VisitDateTime { get; set; }
        public int? Age { get; set; }
        public bool? WasSatisfied { get; set; }
        [StringLength(1)]
        public string Sex { get; set; }
    }
}
