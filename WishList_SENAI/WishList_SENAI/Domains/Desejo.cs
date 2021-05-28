using System;
using System.Collections.Generic;

#nullable disable

namespace WishList_SENAI.Domains
{
    public partial class Desejo
    {
        public int IdDesejo { get; set; }
        public int? IdUsuario { get; set; }
        public string DescricaoDesejo { get; set; }
        public DateTime? DataCriacao { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
