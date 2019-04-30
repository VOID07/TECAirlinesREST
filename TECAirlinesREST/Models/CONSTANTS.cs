using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace TECAirlinesREST.Models
{
    public abstract class CONSTANTS
    {
        public const string M_TYPE = "Message_Type";
        public const string M_DATA = "Message_Data";
        public const string USER_REGISTER = "USER_REGISTER";
        public const string F_NAME = "F_Name";
        public const string M_NAME = "M_Name";
        public const string L_NAME = "L_Name";
        public const string EMAIL = "Email";
        public const string ENROLLED = "Enrolled";
        public const string UNIVERSITY_NAME = "University_Name";
        public const string USERNAME = "Username";
        public const string PASSWORD = "Password";
        public const string CARNET = "Carnet";
        public const string PHONE_NUMBER = "Phone_Number";
        public const string RESPONSE = "RESPONSE";
        public const string REGISTERED = "REGISTERED";
        public const string UNRECOGNIZED_MESSAGE = "Message unrecognized";
        public const string LIST_OF_FLIGHTS = "LIST_OF_FLIGHTS";
        public const string STARTS = "Starts";
        public const string ENDS = "Ends";
        public const string TRIP = "TRIPS";
        public const string TRIP_ID = "Trip_ID";
        public const string STARTS_AIRPORT_CODE = "Starts_Airport_Code";
        public const string STARTS_CITY_NAME = "Starts_City_Name";
        public const string ENDS_AIRPORT_CODE = "Ends_Airport_Code";
        public const string ENDS_CITY_NAME = "Ends_City_Name";
        public const string FLIGHT_SEARCH = "FLIGHT_SEARCH";
        public const string PROMOS = "PROMOS";
        public const string GET_PROMOS = "GET_PROMOS";
    }
}