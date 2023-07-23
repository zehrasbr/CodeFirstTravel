using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Guide
    {
        public int GuideID { get; set; }
        public string GuideName { get; set; }
        public string GuideTitle { get; set; }
        public string ImageUrl { get; set; }
        public List<SocialMedia> SocialMedia { get; set; }
    }
}