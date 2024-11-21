using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_DZ8
{
    public class Payment
    {
        public static Payment salary { get; } = new Payment("Зарплата");
        public static Payment hourly { get; } = new Payment("Почасовая");
        public static Payment piecework { get; } = new Payment("Сдельная");

        public static IReadOnlyList<Payment> All { get; } =
        [
            salary, hourly, piecework
        ];

        public string Name { get; set; }
        private Payment(string name) 
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
