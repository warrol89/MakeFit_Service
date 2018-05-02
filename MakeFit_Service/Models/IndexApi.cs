using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MakeFit_Service.Models
{
    public class IndexApi
    {
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        public static string testmember{get;set;}

        
    }

    public class testapi
    {

        public Dictionary<int, IndexApi> dictionay  { get; set; }
    }

   
}