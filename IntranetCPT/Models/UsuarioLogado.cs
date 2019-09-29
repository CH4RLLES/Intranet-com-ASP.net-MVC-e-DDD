using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IntranetCPT.Models
{
    public class UsuarioLogado
    {
        private readonly IHttpContextAccessor _usuario;
        public string Id => GetClaimsIdentity().FirstOrDefault(a => a.Type == ClaimTypes.NameIdentifier)?.Value;
        public string Nome => GetClaimsIdentity().FirstOrDefault(a => a.Type == ClaimTypes.Name)?.Value;
        public string Token => GetClaimsIdentity().FirstOrDefault(a => a.Type == ClaimTypes.Authentication)?.Value;
        public bool Admin => bool.Parse(GetClaimsIdentity().FirstOrDefault(a => a.Type == ClaimTypes.Actor)?.Value);

        public UsuarioLogado(IHttpContextAccessor usuario)
        {
            _usuario = usuario;
        }

        public IEnumerable<Claim> GetClaimsIdentity()
        {
            return _usuario.HttpContext.User.Claims;
        }
    }
}
