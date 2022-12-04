using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSites.Core
{
    public abstract class NewsSite
    {
        public abstract List<News> haberGetir();
        public int Id { get; set; }
        public string Name { get; set; }
        public string XmlLink { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
