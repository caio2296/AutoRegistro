using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.ViewModel
{
    public class ModelViewVeiculo
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int KmAtual { get; set; }
        public int KmTrocaOleo { get; set; }
    }
}
