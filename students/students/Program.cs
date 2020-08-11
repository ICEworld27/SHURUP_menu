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
            
                
                
                Console.WriteLine("Hello World!");
                Menu main_menu = new Menu();
                Menu aq = main_menu.addSubmenu("h");
                aq.addSimpleMenuItem("aaa", M1);
                main_menu.addSimpleMenuItem("adq", M1);
                aq.addSimpleMenuItem("aaa", M1);



            main_menu.Run();
                
                
            

        }
    }
}
