using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace bloodsaver.Models
{
   [Table("regtable")]

    
    public partial class registration
    {
        public int id {get;set;}
     

        public string name { get; set; }
        
     
       public string cnic { get; set; }
      
      

        public string email { get; set; }
        public string password { get; set; }
        public string gender { get; set; }
        public string status { get; set; }
        public string bloodgroup { get; set; }
       //[Range(1,100)] 
       public string cellno { get; set; }
        public string statuscell { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string textarea { get; set; }
        public string filenames { get; set; }


       

   
   }

    
}