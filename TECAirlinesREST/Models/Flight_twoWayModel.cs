using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TECAirlinesREST.Models
{
    [DataContract]
    public class Flight_twoWayModel
    {
        [DataMember(Name = CONSTANTS.STARTS)]
        public string Starts { get; set; }

        [DataMember(Name = CONSTANTS.ENDS)]
        public string Ends { get; set; }

        [DataMember(Name = CONSTANTS.DATE_RANGE)]
        public string DateRange { get; set; }

        [DataMember(Name = CONSTANTS.TICKS)]
        public string Ticks { get; set; }

        [DataMember(Name = CONSTANTS.PROM_CODE)]
        public string PromCode { get; set; }
    }
}