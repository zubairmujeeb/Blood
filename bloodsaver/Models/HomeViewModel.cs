using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bloodsaver.Models
{
    public class HomeViewModel
    {

        public IEnumerable< registration> registration { get; set; }

        public retriving retriving { get; set; }
       

       

       
        
        public List<countrys> Country { get; set; }

        public List<citys> Cities { get; set; }




        public retriving stid { get; set; }

        public retriving uid { get; set; }
    }
}