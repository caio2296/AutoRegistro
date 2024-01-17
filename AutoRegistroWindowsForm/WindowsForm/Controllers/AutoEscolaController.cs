using Aplicacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRegistro.Controllers
{
    public class AutoEscolaController
    {
        private readonly IAplicacaoAutoEscola aplicacaoAutoEscola;
        public AutoEscolaController(IAplicacaoAutoEscola aplicacaoAutoEscola)
        {
            this.aplicacaoAutoEscola = aplicacaoAutoEscola ?? throw new ArgumentNullException(nameof(aplicacaoAutoEscola));
        }
    }
}
