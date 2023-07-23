using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class SocialMedia
    {
        public int SocialMediaID { get; set; }
        public string SocialMediaName { get; set; }
        public string SocialMediaUrl { get; set; }
        public string Icon { get; set; }
        public int GuideID { get; set; }
        public virtual Guide Guide { get; set; }
    }
}