using Entites.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Entites
{
    public class ApplicationUser: IdentityUser
    {
        [Column("USR_Cpf")]
        public String CPF { get; set; }

        [Column("USR¨_tipo")]
        public TipoUsuario? Tipo { get; set; }
    }
}