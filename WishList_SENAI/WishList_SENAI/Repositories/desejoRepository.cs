using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishList_SENAI.Contexts;
using WishList_SENAI.Domains;
using WishList_SENAI.Interfaces;

namespace WishList_SENAI.Repositories
{
    public class desejoRepository : IDesejoRepository
    {

        wishListContext ctx = new wishListContext();

        public void Cadastrar(Desejo novoDesejo)
        {
            //Adiciona nova Classe
            ctx.Desejos.Add(novoDesejo);

            //salva as informações para serem salvas no banco de dados
            ctx.SaveChanges();
        }

        public List<Desejo> ListarTodos()
        {
            return ctx.Desejos.ToList();
        }
    }
}
