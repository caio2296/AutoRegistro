using Aplicacao.Aplicacoes;
using Aplicacao.Interfaces;
using AutoRegistro.Models;
using AutoRegistro.Token;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRegistro.Controllers
{
    public class AutoEscolaController
    {
        private readonly IAplicacaoAutoEscola _IaplicacaoAutoEscola;
        public AutoEscolaController(IAplicacaoAutoEscola aplicacaoAutoEscola)
        {
            this._IaplicacaoAutoEscola = aplicacaoAutoEscola ?? throw new ArgumentNullException(nameof(aplicacaoAutoEscola));
        }

        public async Task<TokenData> CriarToken(Login login)
        {
            var resultado = await _IaplicacaoAutoEscola.ExisteAutoEscola(login.Nome, login.Senha);
            if (resultado)
            {
                var idUsuario = await _IaplicacaoAutoEscola.RetornarIdAutoEscola(login.Nome);

                var token = new TokenJwtBuilder()
                     .AddSecurityKey(JwtSecurityKey.Creater("Secret_Key-12345678"))
                 .AddSubject("Empresa - Caio Cesar")
                 .AddIssuer("Securiry.Bearer")
                 .AddAudience("Securiry.Bearer")
                 .AddClaim("idUsuario", idUsuario)
                 .AddExpiry(120)
                 .Builder();

                var tokenData = new TokenData
                {
                    IdUsuario = idUsuario,
                    // Adicione outros dados do token conforme necessário
                };

                // Armazene os dados do token no ApplicationState
                ApplicationState.TokenData = tokenData;

                return tokenData;
            }
            return null;
        }
    
    }

    //public async Task<IActionResult> AdicionaUsuario([FromBody] Login login)
    //{
    //    if (string.IsNullOrWhiteSpace(login.email) || string.IsNullOrWhiteSpace(login.senha))
    //        return Ok("Falta alguns dados");
    //    var resultado = await
    //        _IAplicacaoUsuario.AdicionaUsuario(login.email, login.senha, login.idade, login.celular);

    //    if (resultado)
    //        return Ok("Usuário Adicionado com Sucesso");
    //    else
    //        return Ok("Erro ao adicionar usuário");
    //}
}