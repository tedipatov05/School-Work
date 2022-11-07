using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Успехът_на_учениците
{
    internal class Students
    {
        private string firstname;
        private string secondname;
        private List<int> mark;

        public Students(string _firstname,string _secondname, List<int> _marks)
        {
            FirstName = _firstname;
            SecondName = _secondname;
            Mark = _marks;
        }

        public string FirstName
        { get; set; }
         
        public string SecondName
        { get; set; }

        public List<int> Mark
        { set; get; }

        public double Average()
        {
            double sum = 0;
            for(int i=0;i<Mark.Count;i++)
            {
                sum += Mark[i];
            }
            return sum / Mark.Count;
        }

    }
}
