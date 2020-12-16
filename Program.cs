using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank minBank = new Bank("EUC Syd", 41413);
            string bank = minBank.Status();
            string title;
            Console.WriteLine("ffsafsafsafsa");
            Console.Title = "Banken";
            title = minBank.Status();
            Menu(title);
            ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();
            do
            {
                keyinfo = Console.ReadKey(true);
                switch (keyinfo.KeyChar)
                {
                    case '1':
                        Menu("************* Vis status af konto *************\n");
                        Console.ReadLine();
                        break;
                    case '2':
                        Menu("**************** Opret en konto ***************\n");
                        Console.ReadLine();
                        break;
                    case '3':
                        Menu("*********** Indsæt Penge på en konto **********\n");
                        Console.ReadLine();
                        break;
                    case '4':
                        Menu("************ Hæv penge fra en konto ***********\n");
                        Console.ReadLine();
                        break;
                    case '5':
                        Menu("****************** Vis saldo ******************\n");
                        Console.ReadLine();
                        break;
                    case 'X':
                        break;
                }
                Menu(title);
            }
            while (keyinfo.KeyChar != 'x');
        }
        public static void Menu(string title)
        {
            Console.Clear();

            Console.Write("┌───────────────────────────────────────────────┐\n", TextColor(2));
            Console.Write("│", TextColor(2)); Console.Write($"{title}\n", TextColor(1));
            Console.Write("├───────────────────────────────────────────────┤\n", TextColor(2));
            Console.Write("│", TextColor(2)); Console.Write("(1): Vis status af konto\n", TextColor(1));
            Console.Write("│", TextColor(2)); Console.Write("(2): Opret en konto\n", TextColor(1));
            Console.Write("│", TextColor(2)); Console.Write("(3): Indsæt Penge på en konto\n", TextColor(1));
            Console.Write("│", TextColor(2)); Console.Write("(4): Hæv penge fra en konto\n", TextColor(1));
            Console.Write("│", TextColor(2)); Console.Write("(5): Vis saldo\n", TextColor(1));
            Console.Write("│", TextColor(2)); Console.Write("(X): Exit/Back\n", TextColor(1));
            Console.Write("└───────────────────────────────────────────────┘", TextColor(2));
            WriteChar(0, 2);
            WriteChar(48, 1);
            WriteChar(48, 2);
            WriteChar(48, 4);
            WriteChar(48, 5);
            WriteChar(48, 6);
            WriteChar(48, 7);
            WriteChar(48, 8);
            WriteChar(48, 9);
        }
        public static void WriteChar(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("│");
        }
        public static string TextColor(int colorCode)
        {
            switch (colorCode)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    return "";
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    return "";
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    return "";
                default:
                    return "";
            }
        }
    }
}
