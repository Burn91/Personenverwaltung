using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;


namespace Personenverwaltung
{
    public class PersonViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }
        private PersonManager _manager = new PersonManager();

        public PersonViewModel()
        {
            this.Persons = new ObservableCollection<Person>(_manager.Persons());
        }

    }
}
