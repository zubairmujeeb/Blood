using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bloodsaver.Models
{
    public  class retriving 
    {
       
        public int? stid { get; set; }
        public int uid { get; set; }
        public string country { get; set; }
      

        public IList<SelectListItem> StateNames { get; set; }

        public retriving()
        {
            connectioncontext co = new connectioncontext();
            co.allcountry.ToList();
            co.allcities.ToList();
        }

        public List<countrys> con
        {
            get
            {
                connectioncontext co = new connectioncontext();
                return co.allcountry.ToList();
                    
                
            }
        }

        

        public List<citys> conx
        {
            get
            {
                connectioncontext co = new connectioncontext();
                return co.allcities.ToList();
            }
        }

        public List<registration> em
        {
            get
            {
                connectioncontext co = new connectioncontext();
                return co.employess.ToList();
            }
        }


      
       

    }
}