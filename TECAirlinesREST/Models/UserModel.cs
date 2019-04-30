using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using TECAirlinesREST.Models;

namespace TECAirlinesREST.Models
{
    [DataContract]
    public class UserModel
    {
        [DataMember(Name = CONSTANTS.F_NAME)]
        public string F_Name { get; set; }

        [DataMember(Name = CONSTANTS.M_NAME)]
        public string M_Name { get; set; }

        [DataMember(Name = CONSTANTS.L_NAME)]
        public string L_Name { get; set; }

        [DataMember(Name = CONSTANTS.EMAIL)]
        public string Email { get; set; }

        [DataMember(Name = CONSTANTS.M_TYPE)]
        public string Enrolled { get; set; }

        [DataMember(Name = CONSTANTS.UNIVERSITY_NAME)]
        public string University_Name { get; set; }

        [DataMember(Name = CONSTANTS.USERNAME)]
        public string Username { get; set; }

        [DataMember(Name = CONSTANTS.PASSWORD)]
        public string Password { get; set; }

        [DataMember(Name = CONSTANTS.CARNET)]
        public string Carnet { get; set; }

        [DataMember(Name = CONSTANTS.PHONE_NUMBER)]
        public string Phone_Number { get; set; }
    }
}