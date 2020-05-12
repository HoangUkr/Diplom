using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_v2
{
    public class Users
    {
        public string name { get; set; }
        public string login { get; set; }
        public string faculty { get; set; }
        public string chair { get; set; }
        public int year { get; set; }
        public string role { get; set; }
        private string password { get; set; }
    }
}
