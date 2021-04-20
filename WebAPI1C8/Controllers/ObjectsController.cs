using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI1C8.Services;

namespace WebAPI1C8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectsController : ControllerBase
    {
        private readonly ILogger<ObjectsController> _logger;
        private readonly Service1C _service1C;
        public ObjectsController(ILogger<ObjectsController> logger, Service1C service1C)
        {
            _logger = logger;
            _service1C = service1C;
        }
        [HttpGet]
        public object Get(string objectType= "Документ.РеализацияТоваровУслуг", string uuid= "c52c9558-ded8-11e6-9c93-0021ccc279a3")
        {
            return _service1C.GetObjectByUUID(objectType,uuid);
        }
 

    }
}
