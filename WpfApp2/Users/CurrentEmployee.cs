﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Users
{
    public class CurrentEmployee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string secondname { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string position { get; set; }

        public CurrentEmployee()
        {

        }

        public CurrentEmployee(string surn, string name, string secname, string pos)
        {
            this.surname = surn;
            this.name = name;
            this.secondname = secname;
            this.position = pos;
        }

    }
}
