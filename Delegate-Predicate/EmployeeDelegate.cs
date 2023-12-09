using Delegate_Predicate.Models;

namespace Delegate_Predicate
{
    internal class EmployeeDelegate
    {
        public delegate bool CheckSalary(List<Person> person);
        public void GetPersons(List<Person> persons, Predicate<Person> predicate)
        {
            foreach (Person person in persons)
            {
                if (predicate(person))
                {
                    Console.WriteLine($"{person.Name} - {person.Surname}");
                }
            }
        }

        public void Result()
        {
            List<Person> people = new List<Person>()
            {
            new Person() { Name = "Elnur", Surname = "Ismayilov", Salary = 840, Address = "Shamkir" },
            new Person() { Name = "Ali", Surname = "Aslanov", Salary = 820, Address = "Kalbajar" },
            new Person() { Name = "Haciaga", Surname = "Ahmadov", Salary = 970, Address = "Baku" },
            new Person() { Name = "Mermer", Surname = "Ismayilova", Salary = 700, Address = "Tovuz" },

            };

            GetPersons(people, people => people.Salary > 900);
        }
    }
}
