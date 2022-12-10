﻿using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Delete
{
    public class DeleteAmbientesDto
    {
        [Required]
        public bool Status { get; set; }
        [Required]
        public int Id { get; set; }
    }
}
