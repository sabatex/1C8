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
    public class DocumentsController : ControllerBase
    {
        private readonly ILogger<DocumentsController> _logger;
        private readonly Service1C _service1C;
        public DocumentsController(ILogger<DocumentsController> logger, Service1C service1C)
        {
            _logger = logger;
            _service1C = service1C;
        }
        [HttpGet("findByNumber")]
        public object GetDocument(string docName= "РеализацияТоваровУслуг", string docNumber= "0000000001", DateTime? period=null)
        {
            return _service1C.GetDocumentByNumber(docName,docNumber, period==null?new DateTime(2017,1,20):period);
        }
        [HttpGet("getByPeriod")]
        public object GetDocuments(string docName = "РеализацияТоваровУслуг", DateTime? startDate=null, DateTime? endDate = null)
        {
            return _service1C.GetDocumentsByPeriod(docName, startDate,endDate);
        }


    }
}
