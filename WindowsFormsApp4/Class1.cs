using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMlproect
{
    class Employee
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool OnHoliday { get; private set; }

        public Employee(string Name, int Age, bool OnHoliday)
        {
            Name = this.Name;
            Age = this.Age;
            OnHoliday = this.OnHoliday;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
