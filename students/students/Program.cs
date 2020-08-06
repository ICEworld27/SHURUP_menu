using System;

namespace students
{

    class Program
    {
        static void M1()
        {
            Console.WriteLine("ASDADASD");
        }
        static void M2()
        {
            Menu aq = new Menu("QQ");
            aq.Add(new Simple_Item(M2, "aaa"));
            aq.Run();
        }
         static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Menu a = new Menu("d");
            a.Add(new Simple_Item(M1, "a"));
            a.Add(new Simple_Item(M2, "aaa"));
            a.Run();
        }
    }
}
