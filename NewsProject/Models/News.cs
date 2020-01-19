using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.Models
{
    public class News
    {
        public int NewsId { get; set; }

        public string Img { get; set; }
        
        public string Heading { get; set; }
        
        public string ShortDescription { get; set; }
        
        public string FullDescription { get; set; }
    }
}
