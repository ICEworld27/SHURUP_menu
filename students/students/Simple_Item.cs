using System;
using System.Collections.Generic;
using System.Text;

namespace students
{
    class Simple_Item : Item
    {
        public MyCommand comand;
        public Simple_Item(MyCommand com, string titl) : base(titl)
        {
            comand = com;
        }
        public override void Run()
        {
            comand.run();
        }
    }
}
