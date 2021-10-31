using Microsoft.AspNetCore.Mvc;

namespace ApiTest
{
    public class Derived0Controller : BaseController
    {
        [HttpGet("foo0")]
        public new void Foo()
        {
            base.Foo();
        }
    }
}