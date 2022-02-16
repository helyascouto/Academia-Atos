﻿using System.ComponentModel.DataAnnotations;

namespace ConsumindoApi.Models
{
    public class Pessoa
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name ="Nome da pessoa")]
        [StringLength(100,MinimumLength =5)]
        public string nome { get; set; }
    }
}
