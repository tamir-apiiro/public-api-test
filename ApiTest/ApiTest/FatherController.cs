using System.Threading;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest
{
    [Route("1")]
    public abstract class FatherController : Controller
    {
        [HttpGet("f")]
        [HttpGet("g")]
        public virtual void Func()
        {
        }
    }
}