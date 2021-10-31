using Microsoft.AspNetCore.Mvc;

namespace ApiTest
{
    [Route("derived1")]
    public class Derived1Controller : BaseController
    {
        [HttpGet("bar")]
        public void Bar()
        {
        }
        
        [HttpGet("foo1")]
        public override void Foo()
        {
        }
        
        public new void Func()
        {
        }
    }
}