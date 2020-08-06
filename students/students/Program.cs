using System;

namespace students
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Menu a = new Menu("d");
            a.Add(new Simple_Item(new MyCommand(), "a"));
            a.Add(new Simple_Item(new MyCommand2(), "aaa"));
            a.Run();
        }
    }
}
