using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personenverwaltung
{
    public class PersonManager
    {
        public List<Person> Persons()
        {
            List<Person> existingPerson = new List<Person>();
            

            existingPerson.Add(new Person
            {
                PersonFirstName = "Humbold",
                PersonFamilyName = "Holzmann",
                PersonAddress = "Oberhausen",
                PersonSex = "Männlich",
              
            }
            ) ;

            existingPerson.Add(new Person
            {
                PersonFirstName = "Hildegart",
                PersonFamilyName = "Schwimmfrau",
                PersonAddress = "Unterhütting",
                PersonSex = "Weiblich",
             
            }
            ) ;

            existingPerson.Add(new Person
            {
                PersonFirstName = "Sirba",
                PersonFamilyName = "Nachnambertus",
                PersonAddress = "Nebenan",
                PersonSex = "Deivers"
            });

            return existingPerson;
        }



    }
}
