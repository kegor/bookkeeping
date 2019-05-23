namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Expense")]
    public partial class Expense
    {
        public int ID { get; set; }

        public int CategoryID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal Sum { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public virtual Category Category { get; set; }
    }
}
