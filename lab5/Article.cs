using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public enum StatusUnum { CONFIRMED, ERROR, PENDING }
    
    class Article
    {
        public DateTime? date;
        public String id { get; set; }
        public String gtin { get; set; }
        public String lot { get; set; }
        public Double quantity { get; set; }
        public String subsys_art_no { get; set; }
        public Double volume { get; set; }
        public String vetDoc { get; set; }
        public String unit { get; set; }
        public StatusUnum status { get; set; }
        public String errorMessage { get; set; }

        private String[] properties;

        public String this[int i]
        {
            get
            {
                return properties[i];
            }
            set
            {
                properties[i] = value;
            }
        }

        public Article()
        {
            id = "1";
            properties = new String[10];
        }
    }
}
