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
                Console.Clear();
                Menu();
                switch(Insert())
                {
                    case '1':
                        Show();
                        break;
                    case '2':

                        break;
                    case '3':

                        break;
                    case '4':

                        break;
                    case '5':

                        break;
                    case '6':

                        break;
                    case '7':

                        break;
                    case '0':
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect value");
                        break;
                }
            } while (!exit);

            //Console.WriteLine("Enter amount of users to add");
            //int count = int.Parse(Console.ReadLine());
            //InsertTransactiondatarandomUser(count);
        }

        //static void InsertTransactiondatarandomUser(int count = 10)
        //{
        //    using (EFContext context = new EFContext())
        //    {
        //        using (TransactionScope scope = new TransactionScope())
        //        {
        //            List<User> users = new List<User>();
        //            for (int i = 0; i < count; i++)
        //            {
        //                users.Add(new User()
        //                {
        //                    Email = "fdasasdsa@gmail.com",
        //                    Passwords = "jnafsdsjndafjkl"
        //                });
        //            }
        //            context.Users.AddRange(users);
        //            context.SaveChanges();

        //            scope.Complete();
        //        }
        //    }

        //}
        static public void Menu()
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
        static public char Insert()
        {
            Console.WriteLine("Enter:");
            return Console.ReadLine().FirstOrDefault(t => t >= '0' && t <= '7');
        }
        static public void Show()
        {

        }
        static public void Sho2w()
        {

        }
        static public void Sh3ow()
        {

        }
    }
}
