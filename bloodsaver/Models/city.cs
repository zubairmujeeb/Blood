using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bloodsaver.Models
{
    [Table("citytable")]
    public class citys
    {
        public int id { get; set; }
        public string city { get; set; }
        public int countryid { get; set; }
    }
}