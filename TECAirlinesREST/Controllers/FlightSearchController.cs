using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TECAirlinesREST.Models;

namespace TECAirlinesREST.Controllers
{
    public class FlightSearchController : ApiController
    { 
        // GET: api/FlightSearch/5
        public string Get([FromBody]string value)
        {
            try
            {
                MessageModel desJson = JsonConvert.DeserializeObject<MessageModel>(value);
                if (desJson.Message_Type == CONSTANTS.FLIGHT_SEARCH) {
                    FlightModel flightModel = JsonConvert.DeserializeObject<FlightModel>(desJson.Message_Data);

                    //Starting sql request
                    using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=AdventureWorks2014;Integrated Security=SSPI"))
                    using (SqlCommand cmd = new SqlCommand("SELECT BusinessEntityID AS ID, FirstName, MiddleName, LastName FROM Person.Person WHERE FirstName = @FirstName", connection))
                        /*{
                         
                           AQUÍ VA EL QUERY
                           AQUÍ VA EL QUERY
                           AQUÍ VA EL QUERY
                         
                            cmd.Parameters.AddWithValue("FirstName", firstName);
                            connection.Open();
                            using (var reader = cmd.ExecuteReader())
                            {
                                // ...
                            }
                        }*/
                        //end sql request

                        //Falta estructurar el mensaje de regreso necesito saber lo que se tiene
                        return "value";
                }
                else
                {
                    return CONSTANTS.UNRECOGNIZED_MESSAGE;
                }
            }
            catch (Exception e)
            { 
                return "no se pudo procesar la solicitud" + e.GetBaseException().ToString();
            }
        }
    }
}
