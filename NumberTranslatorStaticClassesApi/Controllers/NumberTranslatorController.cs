using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NumberTranslatorStaticClassesApi.Services;

namespace NumberTranslatorStaticClassesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumberTranslatorController : ControllerBase
    {
        [HttpGet("GetNumber/{number}")]
        public string Get(int number)
        {
            return NumberTranslatorService.Translate(number);
        }
    }
}
