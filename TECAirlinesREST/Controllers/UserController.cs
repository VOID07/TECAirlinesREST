using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using TECAirlinesREST.Models;

namespace TECAirlinesREST.Controllers
{
    public class UserRegisterController : ApiController
    {
        // POST: api/User
        public string Post([FromBody]string value)
        {
            /*string json = @"{
                   'CPU': 'Intel',
                   'PSU': '500W',
                   'Drives': [
                     'DVD read/writer'
                     //(broken),
                     '500 gigabyte hard drive',
                     '200 gigabyte hard drive'
                   ]
                }";*/
            try
            {
                MessageModel desJson = JsonConvert.DeserializeObject<MessageModel>(value);
                if (desJson.Message_Type == CONSTANTS.USER_REGISTER)
                {
                    UserModel newUser = JsonConvert.DeserializeObject<UserModel>(desJson.Message_Data);
                    
                    //Starting sql request
                    using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=AdventureWorks2014;Integrated Security=SSPI"))
                    using (SqlCommand cmd = new SqlCommand("UPDATE Person.Person SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName WHERE BusinessEntityID = @BusinessEntityID", connection))
                    {
                        /*cmd.Parameters.AddWithValue("FirstName", firstName);

                        AQUÍ VA EL QUERY
                        AQUÍ VA EL QUERY
                        AQUÍ VA EL QUERY

                        if (middleName == null)
                        {
                            cmd.Parameters.AddWithValue("MiddleName", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("MiddleName", middleName);
                        }
                        cmd.Parameters.AddWithValue("LastName", lastName);
                        cmd.Parameters.AddWithValue("BusinessEntityID", businessEntityID);*/
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    //end sql request

                    return CONSTANTS.REGISTERED;
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
