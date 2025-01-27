﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prestamos.Models
{
    public class Prestamo
    {
        [Key]
        public int Id_prestamo { get; set; }

        [ForeignKey("Usuario")]
        public int Id_usuario { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey("Material")]
        public int Id_material { get; set; }
        public Material ?Material { get; set; }

        [Required]
        public DateTime Fecha_prestamo { get; set; }

        [Required]
        public DateTime Fecha_limite { get; set; }
    }
}
