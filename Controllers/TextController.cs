using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataTools.Services.Interfaces;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Text.Json;
namespace DataTools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        private readonly ITextDataService _textDataService;
        
        public TextController(ITextDataService textDataService)
        {
            _textDataService = textDataService;
        }

        // GET: api/Text
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Text/5
        [HttpGet("{type}", Name = "Get")]
        public async Task<IActionResult> Get(string type)
        {
            TextType _type;
            if (Enum.TryParse<TextType>(type, true, out _type))
            {
                var rt = await _textDataService.GetList(_type);
                return new JsonResult(JsonSerializer.Serialize(rt));
            }
            return null;
        }

        // POST: api/Text
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Content("OK");
        }
        
        //POST: api/Text/Location
        [HttpPost("Location")]
        public IActionResult Location([FromBody] string value)
        {
            return Content("OK");
        }

        // PUT: api/Text/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
