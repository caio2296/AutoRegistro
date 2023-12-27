using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.ViewModel
{
    public class ViewModelManutencao
    {
        public int Id { get; set; }
        public string? NomePeca { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataDaCompra { get; set; }
        public DateTime DataDaInstalacao { get; set; }
        public string? Fabricante { get; set; }
    }
}
