using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSites.Core
{
   public class News
    {
        public override string ToString()
        {
            return this.Title;
        }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
