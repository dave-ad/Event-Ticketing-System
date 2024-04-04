using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return String.Format($"Name: {Name}\nAge: {Age}\n");
        }
    }
}
