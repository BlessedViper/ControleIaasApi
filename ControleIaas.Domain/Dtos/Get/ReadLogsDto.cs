using System;
using System.ComponentModel.DataAnnotations;

namespace ControleIaas.Domain.Dtos.Get
{
    public class ReadLogsDto
    {
        public string Ambiente { get; set; }
        public string Versao { get; set; }
        public DateTime DataAtual { get; set; }
        public string Analista { get; set; }
        public string Ticket { get; set; }
    }
}
