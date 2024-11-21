using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_DZ8
{
    public class Person
    {
        public string Name { get; set; }
        public Payment Payment { get; set; } = Payment.salary;
        public double Salary {  get; set; }
    }
}
