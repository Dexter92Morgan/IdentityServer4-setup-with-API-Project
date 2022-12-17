using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    //[EnableCors("*", "*", "*")]
    public class EmployeeController : ControllerBase
    {

        static List<Employee> empList = new List<Employee>
            {
                new Employee{Id=101,Name="Abhinav",Location="Bangalore",Salary=12345},

                new Employee{Id=102,Name="Abhishek",Location="Chennai",Salary=23456},

                new Employee{Id=103,Name="Akshay",Location="Bangalore",Salary=34567},

                new Employee{Id=104,Name="Akash",Location="Chennai",Salary=45678},

                new Employee{Id=105,Name="Anil",Location="Bangalore",Salary=56789}
            };


        public List<Employee> GetAll()
        {
            return empList;
        }

        //https://localhost:44342/api/Employee

        //https://localhost:44306/.well-known/openid-configuration

        //[HttpPost]
        //public bool Post(Employee employee)
        //{
        //    SqlConnection conn = new SqlConnection(@"Server=ES-SYS-802\SQL2017;Database=EmployeeDB;Trusted_Connection=True;MultipleActiveResultSets=True;");
        //    string query = "insert into EmployeeInfo values(@Id,@Name,@Loc,@Sal)";
        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    cmd.Parameters.Add(new SqlParameter("@Id", employee.Id));
        //    cmd.Parameters.Add(new SqlParameter("@Name", employee.Name));
        //    cmd.Parameters.Add(new SqlParameter("@Loc", employee.Location));
        //    cmd.Parameters.Add(new SqlParameter("@Sal", employee.Salary));
        //    conn.Open();
        //    int noOfRowsAffected = cmd.ExecuteNonQuery();
        //    conn.Close();
        //    return noOfRowsAffected > 0 ? true : false;
        //}
    }
}
