using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet_Practice
{
    public struct Person
    {
        public int weight;
        public string type;
        public bool sex;
    }
    public class MyLogic
    {
        public bool Button_Save(Person person)
        {
            return MyModel.Write_DB(person);
        }
    }
}
