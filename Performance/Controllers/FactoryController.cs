using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Performance.Application.IServices;
namespace API_Performance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactoryController : ControllerBase
    { 
        private readonly IFactoryService _service ;
        public FactoryController(IFactoryService service)
        {
            this._service = service;
        }

        
      [HttpGet("/factories")] 
      public IActionResult GetAll() 
      {  
           var result = _service.GetAllAsync().Result;
            return Ok(result.ToList());
      }   
    }
}
