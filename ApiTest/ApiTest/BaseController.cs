using Microsoft.AspNetCore.Mvc;

namespace ApiTest
{
    [Route("base")]
    public abstract class BaseController : Controller
    {
        [HttpGet("foo")]
        public virtual void Foo()
        {
        }
        
        [HttpGet("func")]
        public void Func()
        {
        }
    }
}