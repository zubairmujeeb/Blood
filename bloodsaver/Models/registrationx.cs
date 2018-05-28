using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace bloodsaver.Models
{
    [MetadataType(typeof(userdata))]
    public partial  class registration
    {

    }

    public class userdata
    {
       // [Required(ErrorMessage = "Please enter your Email")]
        [Remote("checkemail", "Home", ErrorMessage = "Email Already Exsist")]
        public string email{ get; set;}

        //[Required(ErrorMessage = "Please enter your Cnic")]
         [Remote("checkcnic", "Home", ErrorMessage = "cnic Already Exsist")]
        public string cnic { get; set; }

        //[Required(ErrorMessage="Please enter your name")]
         public string name { get; set; }

       //[Required(ErrorMessage = "Please enter your Password")]
       // public string password { get; set; }
       // [Required(ErrorMessage = "Please Select your Gender")]
       // public string gender { get; set; }
       // [Required(ErrorMessage = "Please Select your status ")]
       // public string status { get; set; }
       // [Required(ErrorMessage = "Please Select your Blood Group")]
       // public string bloodgroup { get; set; }
       // //[Range(1,100)] 
       // [Required(ErrorMessage = "Please enter your Cell Number")]
       // public int cellno { get; set; }
       // [Required(ErrorMessage = "Please Select your cell status ")]
       // public string statuscell { get; set; }
       // [Required(ErrorMessage = "Please Select your Country")]
       // public string country { get; set; }
       // [Required(ErrorMessage = "Please Select your City")]
       // public string city { get; set; }

    }
}