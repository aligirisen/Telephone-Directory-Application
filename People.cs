using System;
sdfs
namespace Telephone_Directory_Application
{
    public class People
    {
        public List<Person> persons = new List<Person>();

        public void people()
        {
            persons.Add(new Person("Ahmed", "Kuna", "05431564"));
            persons.Add(new Person("Ali", "fersah", "054784561"));
            persons.Add(new Person("Kemal", "Ridaniyeli", "056124878"));
            persons.Add(new Person("Murat", "fıstıkçı", "053154678"));
            persons.Add(new Person("Mehmet", "kayıkçı", "0584653"));
        }

    }
}