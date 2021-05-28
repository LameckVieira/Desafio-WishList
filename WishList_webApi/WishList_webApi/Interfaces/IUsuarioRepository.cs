using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WishList_webApi.Interfaces
{
    interface IUsuarioRepository
    {
        public int idUsuario { get; set; }

        public string email { get; set; }

        public string senha { get; set; }
    }
}
