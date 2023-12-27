using Entidades.Notificacoes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Entidades
{
    [Table("TB_Veiculo")]
    public class Veiculo:Notifica
    {
        public Veiculo()
        {
            Manutencoes = new List<Manutencao>();
        }
        [Column("SLT_ID")]
        public int Id { get; set; }
        [Column("SLT_Modelo")]
        public string Modelo { get; set; }
        [Column("SLT_Placa")]
        public string Placa { get; set; }
        [Column("SLT_KmAtual")]
        public int KmAtual { get; set; }
        [Column("SLT_KmTrocaOleo")]
        public int KmTrocaOleo { get; set; }
        [Column("SLT_IdAutoEscola")]
        public string IdAutoEscola { get; set; }
        public AutoEscola AutoEscola { get; set; }
        public List<Manutencao> Manutencoes { get; set; }
    }
}
