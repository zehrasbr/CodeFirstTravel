using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class ContactSocial
    {
        public int ContactSocialID { get; set; }
        public string ContactSocialName { get; set; }
        public string ContactSocialURL{ get; set; }
        public string ContactSocialIcon{ get; set; }
    }
}