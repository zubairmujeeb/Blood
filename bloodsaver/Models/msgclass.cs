using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bloodsaver.Models
{
    [Table("msgtable")]
    public class msgclass
    {
        public string msgbody { get; set; }
       
    }
}