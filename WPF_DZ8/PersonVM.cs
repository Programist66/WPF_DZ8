using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_DZ8
{
    public class PersonVM : BindableBase
    {
        public Person Person {  get;}

        public PersonVM(Person person)
        {
            Person = person;
        }

        private static IReadOnlyList<Payment> allPayments = Payment.All;
        public IReadOnlyList<Payment> AllPayments => allPayments;

        public Payment Payment 
        {
            get {  return Person.Payment; }
            set 
            {
                Person.Payment = value;
                RaisePropertyChanged(nameof(Payment));
                RaisePropertyChanged(nameof(HourVisibility));
            } 
        }
        public Visibility HourVisibility => Payment == Payment.hourly ? Visibility.Visible : Visibility.Collapsed;

        private int hourCount = 0;
        public int HourCount 
        {
            get { return hourCount; }
            set 
            {
                SetProperty(ref hourCount, value);
            } 
        }
    }
}
