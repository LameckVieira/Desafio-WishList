using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WishList_webApi.Interfaces
{
    interface IDesejoRepository
    {
        public int idDesejo { get; set; }

        public int idUsuario { get; set; }

        public string descricao { get; set; }
    }
}
