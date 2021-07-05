using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearnEnglishDoingNotes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntryController : ControllerBase
    {
        // GET: api/<EntryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return null;
        }
    }
}
