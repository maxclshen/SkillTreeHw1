namespace SkillTreeHw1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using SkillTreeHw1.Models;

    [Table("AccountBook")]
    public partial class AccountBook
    {
        public Guid Id { get; set; }

        public int Categoryyy { get; set; }
        
        [Range(1, int.MaxValue)]
        public int Amounttt { get; set; }

        [CantGreaterThanToday]
        public DateTime Dateee { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Remarkkk { get; set; }
    }
}
