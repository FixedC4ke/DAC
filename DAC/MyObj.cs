using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3SovrIS
{
    public class MyObj
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public MyObj(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
