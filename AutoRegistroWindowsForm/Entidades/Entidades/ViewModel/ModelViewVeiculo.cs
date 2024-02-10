using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.ViewModel
{
    public class ModelViewVeiculo
    {
        public int Id { get; set; }
        [StringLength(10, MinimumLength = 2)]
        public string Modelo { get; set; }
        [StringLength(10, MinimumLength = 7)]
        public string Placa { get; set; }
        [Range(0,9999999)]
        public int KmAtual { get; set; }
        [Range(0, 9999999)]
        public int KmTrocaOleo { get; set; }
        public int IdAutoEscola { get; set; }
    }
}
