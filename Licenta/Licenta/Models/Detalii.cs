﻿using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Licenta.Models
{
    public class Detalii
    {
        public int Id { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }

        [Required]
        [PersonalData]
        [DisplayName("Varsta")]
        [Range(18, 65, ErrorMessage = "Trebuie sa aveti varsta cuprinsa intre {1} si {2}")]
        [Column(TypeName = "int")]
        public int Varsta { get; set; }

        [Required]
        [PersonalData]
        [DisplayName("Greutate")]
        [Range(40, 160, ErrorMessage ="Daca nu aveti greutatea cuprinsa intre {1} si {2} va rugam sa faceti un control la doctor")]
        [Column(TypeName = "int")]
        public int Greutate { get; set; }

        [PersonalData]
        [DisplayName("Inaltimea")]
        [Column(TypeName = "int")]
        [Range(100,220)]
        public int Inaltimea { get; set; }

        [DisplayName("Data")]
        [Column(TypeName = "DateTime")]
        public DateTime Data { get; set; } = DateTime.Now;

        [PersonalData]
        [DisplayName("Grasime Corporala")]
        [Column(TypeName = "float")]
        public double Rezultat1 { get; set; }

        [PersonalData]
        [DisplayName("Grad")]
        [Column(TypeName = "nvarchar(100)")]
        public string Rezultat2 { get; set; }
    }
}