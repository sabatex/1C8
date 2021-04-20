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
    public class MetadataController : ControllerBase
    {
        private readonly ILogger<MetadataController> _logger;
        private readonly Service1C _service1C;
        public MetadataController(ILogger<MetadataController> logger, Service1C service1C)
        {
            _logger = logger;
            _service1C = service1C;
        }
        
        [HttpGet("enums")]
        public IEnumerable<object> GetEnums()
        {
            return _service1C.GetEnumsMetadata();
        }

        [HttpGet("catalogs")]
        public IEnumerable<object> GetCatalogs()
        {

            return _service1C.GetCatalogMetadataNames();
        }

        [HttpGet("documentss")]
        public IEnumerable<object> GetDocuments()
        {

            return _service1C.GetDocumentMetadataNames();
        }


    }
}
