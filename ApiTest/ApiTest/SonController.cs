using Microsoft.AspNetCore.Mvc;

namespace ApiTest
{
    [Route("2")]
    public class SonController : FatherController
    {
        [Nothing]
        [HttpPost("j")]
        public override void Func()
        {
        }
    }
}