using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TECAirlinesREST.Models
{
    [DataContract]
    public class TripInfoModel
    {
        [DataMember(Name = CONSTANTS.TRIP_ID)]
        public string Trip_ID {get; set;}
    }
}