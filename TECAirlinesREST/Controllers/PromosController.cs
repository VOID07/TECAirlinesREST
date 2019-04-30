using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TECAirlinesREST.Controllers
{
    public class PromosController : ApiController
    {
        // GET: api/Promos
        public IEnumerable<string> Get()
        {
            //Starting sql request
            using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=AdventureWorks2014;Integrated Security=SSPI"))
            using (SqlCommand cmd = new SqlCommand("SELECT BusinessEntityID AS ID, FirstName, MiddleName, LastName FROM Person.Person WHERE FirstName = @FirstName", connection))
                /*{
                 * 
                 * AQUÍ VA EL QUERY
                 * AQUÍ VA EL QUERY
                 * AQUÍ VA EL QUERY
                    cmd.Parameters.AddWithValue("FirstName", firstName);
                    connection.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        // ...
                    }
                }*/
                //end sql request
            return new string[] { "value1", "value2" };
        }
    }
}
