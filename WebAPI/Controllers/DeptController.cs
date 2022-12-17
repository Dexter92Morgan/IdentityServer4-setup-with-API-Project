using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeptController : ControllerBase
    {

        static List<DeptInfo> depList = new List<DeptInfo>
            {
                new DeptInfo{Id=1,Name="Dev",Revenue=5000},

                new DeptInfo{Id=2,Name="Bigv Data",Revenue=10000},

                new DeptInfo{Id=3,Name="Mobility",Revenue=150000},

            };

        [HttpGet("get.{format}"), FormatFilter]
        public List<DeptInfo> GetAll()
        {
            return depList;
        }


    }
}
