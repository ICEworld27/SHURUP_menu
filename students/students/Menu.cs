using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
namespace students
{

    class Menu : Item
       {
        private bool sub;
        private Item[] items =  new Item[0];
        public void print_menu()
        {
            
            for (int i = 0; i < items.Length; i++)
            {

                Console.WriteLine((i + 1) + ". " + items[i].get_title());
            }
            //if (this is Menu)
            //{
                Menu oi = (Menu)this;
                
                if (oi.getSub() == true)
                {
                    Console.WriteLine((items.Length + 1) + ". назад");
                }
                else
                {
                    Console.WriteLine((items.Length + 1) + ". выход");
                }
           // }
            
            Console.Write("Введите нужный номер: ");
        }
        public bool HandleUserInput()
        {
            int asd = Convert.ToInt32(Console.ReadLine());
            if (asd-1 < items.Length && asd-1 > -1)
            {
                items[asd-1].Run();
                return false;
            }
            else
            {
                if (asd-1 == items.Length)
                {
                    return true;
                }
            }
            return false;
        }

        public override void Run() 
        {
            while (true)
            {
                print_menu();
                if (HandleUserInput() == true)
                {
                    return;
                }
            }

        }
        public void addSimpleMenuItem(string title, Action action)
        {
            // создать пункт меню и добавить в массив
            Simple_Item r = new Simple_Item(action, title);
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = r;
        }
        public Menu addSubmenu(string title)
        {
            Menu qwe = new Menu(title, true);
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = qwe;
            return qwe;
            //return ref qwe;
            // создать экземпляр меню и сообщить ему, что он -- подменю
            // добавить этот экземпляр в массив
            // вернуть ссылку на экземпляр
        }
        public bool getSub()
        {

            return sub;
            //return ref qwe;
            // создать экземпляр меню и сообщить ему, что он -- подменю
            // добавить этот экземпляр в массив
            // вернуть ссылку на экземпляр
        }
        /*
        public void Add(Item a)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = a;
        }
        */
        public Menu() : base("")
        {
            int[] z = new int[0];
        }
        private Menu(string title, bool submenu = false) : base(title)
        {
            sub = submenu;
            //int[] z = new int[0];
        }
    }
}
