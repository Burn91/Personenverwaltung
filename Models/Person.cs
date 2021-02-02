using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personenverwaltung
{
    public class Person : INotifyPropertyChanged
    {
        private string _firstName;
        private string _familyName;
        private string _address;
        private string _sex;

        public string PersonFirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                OnProbertyChanged("PersonFirstName");
            }
        }

        public string PersonFamilyName
        {
            get
            {
                return _familyName;
            }
            set
            {
                _familyName = value;
                OnProbertyChanged("PersonFamilyName");
            }
        }
        
        public string PersonAddress
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                OnProbertyChanged("PersonAdress");
            }
        }

        public string PersonSex
        {
            get
            {
              return _sex;
            }
            set
            {
                _sex = value;
                OnProbertyChanged("PersonGeschlecht");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnProbertyChanged(string probertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(probertyName));
            }
        }
    }
}
