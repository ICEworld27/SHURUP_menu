using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
namespace students
{
    class Menu : Item
    {
        private Item[] items =  new Item[0];
        public void print_menu()
        {
            
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + items[i].get_title());
            }
            Console.WriteLine((items.Length+1) + ". выход");
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
        public void Add(Item a)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = a;
        }
        public Menu(string title) : base(title)
        {
            int[] z = new int[0];
        }
    }
}
