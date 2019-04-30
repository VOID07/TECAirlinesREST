using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TECAirlinesREST.Models
{
    [DataContract]
    public class MessageModel
    {
        [DataMember(Name = "Message_Type")]
        public string Message_Type { get; set; }

        [DataMember(Name = "Message_Data")]
        public string Message_Data { get; set; }
    }
}