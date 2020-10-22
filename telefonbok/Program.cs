using System;
using System.Collections;

namespace telefonbok
{
    class Program
    {
        static ArrayList telBookArr = new ArrayList ();

        static void Main(string[] args)
        {
            var selection = "0";

            while (selection != "6")
            {
                Console.Clear();
                Console.WriteLine("1 : enter information");
                Console.WriteLine("2 : display information");
                Console.WriteLine("3 : search information");
                Console.WriteLine("4 : edit information");
                Console.WriteLine("5 : delete information");
                Console.WriteLine("6 : exit");

                Console.Write("\nenter your choose : ");
                selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        enter_info();
                        break;
                    case "2":
                        show_info();
                        break;
                    case "3":
                        search_ifo();
                        break;
                    case "4":
                        edit_info();
                        break;
                    case "5":
                        delet_ifo();
                        break;
                    default:
                        Console.WriteLine("Please enter valid selection 1 - 6"); ;
                        break;
                }
            }
        }

        static void enter_info()
        {
            Console.Clear();

            Personupgifter t = new Personupgifter();

            Console.Write("enter name : ");
            t.name = Console.ReadLine();

            Console.Write("enter family : ");
            t.family = Console.ReadLine();

            Console.Write("enter mobile : ");
            t.mobile = Console.ReadLine();

            Console.Write("enter other number, homer or work for example : ");
            t.notMobile = Console.ReadLine();

            telBookArr.Add(t);
        }

        static void show_info()
        {
            Console.Clear();

            // editen fungerar inte heller
            foreach (Personupgifter temp in telBookArr)
            {
                Console.WriteLine("name : " + temp.name);
                Console.WriteLine("family : " + temp.family);
                Console.WriteLine("tel : " + temp.mobile);
                Console.WriteLine("tel : " + temp.notMobile);
                Console.WriteLine(" ");
                break;
                

                
            }
            Console.ReadKey();


        }

        static void search_ifo()
        {

            Console.Clear();
            Console.WriteLine("please enter the number: ");
            telBookArr[0] = Console.Read();
            Console.WriteLine("please enter the family: ");
        }
        static void edit_info()
        {
            Console.Clear();
            search_ifo();
        }
        static void delet_ifo()
        {
            Console.Clear();
        }
    }
}




