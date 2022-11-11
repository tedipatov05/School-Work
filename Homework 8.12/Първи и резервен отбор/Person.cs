using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Първи_и_резервен_отбор
{
    internal class Person
    {
        
        public Person(string _firstname, string _secondname, int _age, double _salary)
        {

            FirstName = _firstname;
            SecondName = _secondname;
            Age = _age;
            Salary = _salary;

        }
        public string FirstName
        { set; get; }
        public string SecondName
        { set; get; }
        public int Age
        { set; get; }
        public double Salary
        { set; get; }
    }
}
