namespace SkillTreeHw1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountBook")]
    public partial class AccountBook
    {
        public Guid Id { get; set; }

        public int Categoryyy { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Amounttt { get; set; }

        [CantGreaterThanToday]
        public DateTime Dateee { get; set; }
        
        [StringLength(100)]
        public string Remarkkk { get; set; }
    }
}
