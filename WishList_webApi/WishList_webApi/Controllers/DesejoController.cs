using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishList_webApi.Interfaces;
using WishList_webApi.Repositories;

namespace WishList_webApi.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class DesejoController : ControllerBase
    {
        private IDesejoRepository _desejoRepository;

        public DesejoController()
        {
            _desejoRepository = new DesejoRepository();
        }
    }
}
