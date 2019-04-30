using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TECAirlinesREST.Models;

namespace TECAirlinesREST.Controllers
{
    public class TripInfoController : ApiController
    {
        
        // GET: api/TripInfo/5
        public string Get(string value)
        {
            MessageModel desJson = JsonConvert.DeserializeObject<MessageModel>(value);
            if (desJson.Message_Type == CONSTANTS.FLIGHT_SEARCH)
            {
                TripInfoModel trip = JsonConvert.DeserializeObject<TripInfoModel>(desJson.Message_Data);
                return "value";
            } else
            {
                return CONSTANTS.UNRECOGNIZED_MESSAGE;
            }
        }
        
    }
}
