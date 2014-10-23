using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxApp
{
    class Student
    {
        public string RegNo { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }

        public Student(string regNo, string name, string address)
        {
            this.RegNo = regNo;
            Name = name;
            Address = address;
        }
    }
}
