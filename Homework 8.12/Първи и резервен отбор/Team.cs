using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Първи_и_резервен_отбор
{
    internal class Team
    {

        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            Name = name;
            FirstTeam = new List<Person>();
            ReserveTeam = new List<Person>();
        }

        public string Name{ set; get; }

        public List<Person> FirstTeam
        {
            set { this.firstTeam = value; }
            get { return firstTeam; }
        }

        public List<Person> ReserveTeam
        {
            set { this.reserveTeam = value; }
            get { return reserveTeam; }
        }

        public void Output(Person person)
        {

            if (person.Age < 40)
            {
                FirstTeam.Add(person);
            }
            else if (person.Age >= 40)
            {
                ReserveTeam.Add(person);
            }
            

        }


    }
}
