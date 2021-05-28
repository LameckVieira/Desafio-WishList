using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishList_SENAI.Domains;

namespace WishList_SENAI.Interfaces
{
    interface IDesejoRepository
    {
        /// <summary>
        /// Cadastra um novo desejo
        /// </summary>
        /// <param name="novoDesejo"></param>
        void Cadastrar(Desejo novoDesejo);

        /// <summary>
        /// Lista os desejos
        /// </summary>
        /// <returns></returns>
        List<Desejo> ListarTodos();

    }
}
