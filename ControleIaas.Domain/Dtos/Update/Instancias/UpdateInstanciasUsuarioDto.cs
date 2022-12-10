﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Update.Instancias
{
    public class UpdateInstanciasUsuarioDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Usuario { get; set; }
    }
}
