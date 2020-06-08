using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace salonkrasotbl.Models
{
    public class Orders
    {
        public int ID { get; set; }
        public string sotrudnik { get; set; }
        public int stoimost { get; set; }
        public string usluga { get; set; }
        public DateTime vremja { get; set; }
    }
}