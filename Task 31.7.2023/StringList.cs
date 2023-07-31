using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_31._7._2023
{
    internal class StringList
    {
        private string[] _stringList;

        public StringList()
        {
            _stringList = new string[0];
        }
        public void Add(string str)
        {
            Array.Resize(ref _stringList, _stringList.Length + 1);
            _stringList[_stringList.Length - 1] = str;
        }
        public string[] GetAll()
        {
            return _stringList;
        }
    }
}
