using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }

    namespace TestCode 
    {
        [Route("base")]
        [ApiController]
        public abstract class MyAbstractController : ControllerBase
        {
            [HttpGet("foo")]
            [HttpPost("foo")]   
            public int Foo() 
            {
                return 0;
            }

            [HttpGet("func")]
            public virtual int Func()
            {
                return 3;
            }
        }
                    
        // public class MyConcreteController : MyAbstractController
        // {
        //     [HttpGet("bar")]
        //     public int Bar() 
        //     {
        //         return 0;
        //     }
        // }
                    
        // [Route("route")]
        // public class MyConcreteRoutingController : MyAbstractController
        // {
        // }
                    
        [Route("new")]
        public class MyConcreteNewController : MyAbstractController
        {
            [HttpGet("newfoo")]
            public new int Foo() 
            {
                return 1;
            }
        }
                    
        // [Route("overriding")]
        // public class MyConcreteOverridingController : MyAbstractController
        // {
        //     public override int Func() 
        //     {
        //         return 1;
        //     }
        // }
    }
}