using System;
using System.Collections.Generic;
using System.Text;
using Realms;

namespace I_am_a_programmer.Views.Buttons
{
    public class Person : RealmObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
    }

    public class GasStation :RealmObject
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string TimeWork { get; set; }
    }
}


