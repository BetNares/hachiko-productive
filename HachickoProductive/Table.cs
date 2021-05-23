namespace HachickoProductive
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nama_Tugas { get; set; }

        [Required]
        [StringLength(100)]
        public string Matkul { get; set; }

        public DateTime? Deadline { get; set; }

        [StringLength(500)]
        public string Deskripsi { get; set; }
    }
}
