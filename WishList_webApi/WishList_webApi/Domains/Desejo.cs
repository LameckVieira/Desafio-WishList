using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WishList_webApi.Domains
{
    public class Desejo
    {
        public int idDesejo { get; set; }

        public int idUsuario { get; set; }

        public string desejo { get; set; }
    }
}
