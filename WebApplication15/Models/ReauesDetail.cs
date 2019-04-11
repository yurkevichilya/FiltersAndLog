using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public class ReauesDetail
    {
        public int Id { get; set; }
        public string Requesttime { get; set; }    
        public string RequestURI { get; set; }  
        public string Querystring { get; set; }
        public string StatusCode { get; set; }
    }
}