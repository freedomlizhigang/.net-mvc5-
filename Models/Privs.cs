using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace w_test.Models
{
    public class Privs
    {
        public int id { get; set; }
        public string name { get; set; }
        public string yflb{ get; set; }
        public string url { get; set; }
        public string label { get; set; }
        public bool display { get; set; } = true;
    }
}