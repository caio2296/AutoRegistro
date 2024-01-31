using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRegistro.Models
{
    public class VeiculoModel
    {
        public static int IdVeiculo { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public int KmAtual { get; set; }
        public int KmTroca { get; set; }

    }
}
