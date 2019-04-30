using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TECAirlinesREST.Models
{
    [DataContract]
    public class FlightModel
    {
        [DataMember(Name = CONSTANTS.STARTS_AIRPORT_CODE)]
        public string S_Code { get; set; }

        [DataMember(Name = CONSTANTS.STARTS_CITY_NAME)]
        public string S_CITY { get; set; }

        [DataMember(Name = CONSTANTS.ENDS_AIRPORT_CODE)]
        public string E_Code { get; set; }

        [DataMember(Name = CONSTANTS.ENDS_CITY_NAME)]
        public string E_City { get; set; }

    }
}