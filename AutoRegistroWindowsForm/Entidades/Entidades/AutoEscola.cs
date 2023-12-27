using Entidades.Notificacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    [Table("TB_AutoEscola")]
    public class AutoEscola:Notifica
    {
        public AutoEscola() => Veiculos = new List<Veiculo>();

        [Column("SLT_ID")]
        public int Id { get; set; }
        [Column("SLT_NomeAutoEscola")]
        public string NomeAutoEscola { get; set; }
        [Column("SLT_SENHA")]
        public string Senha { get; set; }
        public List<Veiculo> Veiculos { get; set; }
    }
}
