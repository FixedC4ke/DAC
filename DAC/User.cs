using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3SovrIS
{
    public class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Privelege { get; set; }

        public User(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        public User()
        {
            ID = Guid.Empty;
            Name = String.Empty;
        }
    }
}
