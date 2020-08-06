using System;

namespace students
{

    class Program
    {
        static void M1()
        {
            Console.WriteLine("ASDADASD");
        }
         static void Main(string[] args)
        {

                Menu aq = new Menu("QQ");
                aq.Add(new Simple_Item(M1, "aaa"));
                Console.WriteLine("Hello World!");
                Menu a = new Menu("d");
                a.Add(new Simple_Item(M1, "a"));
                a.Add(aq);

                a.Run();
                
                
            

        }
    }
}
