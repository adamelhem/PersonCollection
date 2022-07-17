using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCollection
{
    public class Person : IPerson
    {
        private DateTime _getDateOfBirth;
        private string _getFirstName;
        private int _getHeight;
        private int _getId;
        private string _getLastName;

        public Person(DateTime getDateOfBirth, string getFirstName, int getHeight, int getId, string getLastName)
        {
            _getDateOfBirth = getDateOfBirth;
            _getFirstName = getFirstName;
            _getHeight = getHeight;
            _getId = getId;
            _getLastName = getLastName;
        }

        public DateTime getDateOfBirth() => _getDateOfBirth;

        public string getFirstName() => _getFirstName;

        public int getHeight() => _getHeight;

        public int getId() => _getId;

        public string getLastName() => _getLastName;
    }
}
