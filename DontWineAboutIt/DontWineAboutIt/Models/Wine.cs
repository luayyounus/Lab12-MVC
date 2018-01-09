using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DontWineAboutIt.Models
{
    public class Wine
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string Designation { get; set; }
        public string Points { get; set; }
        public int Price { get; set; }
        public string Province { get; set; }
        public string Region1 { get; set; }
        public string Region2 { get; set; }
        public string Variety { get; set; }
        public string Winery { get; set; }
    }
}
