namespace projectEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Request")]
    public partial class Request
    {
        [Key]
        [Column("Req No.")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Req_No_ { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReqDate { get; set; }

        public int? P_code { get; set; }

        [StringLength(50)]
        public string W_name { get; set; }

        [StringLength(50)]
        public string S_name { get; set; }

        public virtual Product Product { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
