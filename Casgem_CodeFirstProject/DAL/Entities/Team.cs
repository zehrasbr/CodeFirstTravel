using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Team
    {
        public int TeamID { get; set; }
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string MediaUrl { get; set; }

    }
}