using EKZ_BoolShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKZ_BoolShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            bool exit = false;
            do
            {
                LogMenu();
                switch (MenuInsert())
                {
                    case 1: if (LogIn()) MenuCode(); break;
                    case 2: if (Register()) MenuCode(); break;
                    case 0: exit = true; break;
                    default: Console.WriteLine("Incorrect value"); break;
                }
            } while (!exit);
        }
        static public void LogMenu()
        {
            Console.WriteLine("1 - LogIn");
            Console.WriteLine("2 - Register");
            Console.WriteLine("0 - Exit");
        }
        static public void MenuShow()
        {
            Console.WriteLine("1 - Show");
            Console.WriteLine("2 - Add");
            Console.WriteLine("3 - Remove");
            Console.WriteLine("4 - Edit");
            Console.WriteLine("5 - Sell");
            Console.WriteLine("6 - Сallout");
            Console.WriteLine("7 - Decommission");
            Console.WriteLine("0 - Exit");
        }
        static public void MenuCode()
        {
            bool exit = false;
            do
            {
                Console.Clear();
                MenuShow();
                switch (MenuInsert())
                {
                    case 1: Show(); break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 0: exit = true; break;
                    default: Console.WriteLine("Incorrect value"); break;
                }
            } while (!exit);
        }
        static public int MenuInsert()
        {
            Console.WriteLine("Enter:");
            return int.Parse(Console.ReadLine());
        }
        static public bool LogIn()
        {
            Console.Clear();

            Console.Write("Enter login:");
            string login = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter password:");
            string password = Console.ReadLine();
            Console.WriteLine();

            bool isAvailable = false;
            using (EFContext context = new EFContext())
            {
                isAvailable = context.Account.Contains(new Account(login, password));
            }

            if (isAvailable)
            {
                Console.Write("Completed successfully");
                return true;
            }
            else
            {
                Console.WriteLine("Unsuccessfull, repeat?");
                Console.Write("Enter 0 for exit: ");
                switch (MenuInsert())
                {
                    case 0: LogIn(); break;
                    default: break;
                }
                return false;
            }
        }
        static public bool Register()
        {
            Console.Clear();

            Console.Write("Enter login:");
            string login = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter password:");
            string password = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Repeat password:");
            string repeatPassword = Console.ReadLine();
            Console.WriteLine();

            if (password.Equals(repeatPassword))
            {
                using (EFContext context = new EFContext())
                {
                    context.Account.Add(new Account(login,password));
                    Console.Write("Completed successfully");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Unsuccessfull, repeat?");
                Console.Write("Enter 0 for exit: ");
                switch (MenuInsert())
                {
                    case 0: Register(); break;
                    default: break;
                }
                return false;
            }
        }
        static public void Show()
        {
            using (EFContext context = new EFContext())
            {
                foreach (var item in context.Book)
                {
                    Console.WriteLine(item.Author);
                }
            }
        }
    }
}
