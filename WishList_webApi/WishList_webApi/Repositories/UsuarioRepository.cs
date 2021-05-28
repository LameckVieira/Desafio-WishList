using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishList_webApi.Context;
using WishList_webApi.Domains;
using WishList_webApi.Interfaces;

namespace WishList_webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public int idUsuario { get; set; }
       

        WishListContext ctx = new WishListContext();

        public Usuario Login(string email, string senha)
        {
            return ctx.usuario.FirstOrDefault(u => u.Email == email
                            && u.Senha == senha);
        }
    } 
}
