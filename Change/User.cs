using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Multiple_choice_test_program
{
    [Serializable]
    public class User
    {
        private string name;
        public string Name { get => name; set => name = value; }
        public User()
        {
        }
        public User(string name)
        {
            Name = name;
        }
    }
}
