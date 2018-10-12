using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Data_Storage_and_Process
    {
        public static int minimum, maximum; //User Define
        public static int def_minimum = -50, def_maximun = 50; //Pre-Define
        public static int def_min_point_location_inGraph = -20, def_max_point_location_inGraph = 20;

        public int temp_Generate_data;

        public List<int> List_General_Random_Number = new List<int>();
        public struct Location_XandY_value
        {
            public int X_value;
            public int Y_value;
        }
        List<Location_XandY_value> Location_XandY_Values = new List<Location_XandY_value>();

        //Storage
        ///////////////////////////////////////////////////////
        //Functions


    }

    public class Menu_Display_and_Select
    {
        bool redo; static char Language;

        void Double_New_Lines()
        {
            Console.WriteLine("\n");
        }

        void Language_Error(string name)
        {
            Console.WriteLine("An error occured in "+name);
            Console.Beep(1000, 200);
            Console.ReadKey();
            Environment.Exit(0);
        }

        public void Select_language()
        {
            Console.Write(
                "Enter a numbe to select language (Use English if other language has display issues)\n" +
                "1. English" + "\t" + "2. 中文\n");
            redo = false;
            do
            {
                Console.Write("Enter a number: ");
                Language = Console.ReadKey().KeyChar;
                switch (Language)
                {
                    case '1':
                        Console.WriteLine("\tLanguage is set to English.\n");
                        redo = false;
                        break;
                    case '2':
                        Console.WriteLine("\t中文已被選定為顯示語言\n");
                        redo = false;
                        break;
                    default:
                        Console.WriteLine("\tInput error.\n");
                        Display_ReEnter();
                        redo = true;
                        break;
                }
            } while (redo);
        }


        public void Display_ReEnter()
        {
            switch (Language)
            {
                case '1':
                    Console.WriteLine("Please try again:");
                    break;
                case '2':
                    Console.WriteLine("請重新試一次：");
                    break;
                default:
                    Language_Error("Display_ReEnter()");
                    break;
            }
        }

        public void Display_InputError()
        {
            switch (Language)
            {
                case '1':
                    Console.WriteLine("You entered somthing wrong. ");
                    break;
                case '2':
                    Console.WriteLine("用家輸入有誤");
                    break;
                default:
                    Console.WriteLine("Display_InputError()");
                    break;
            }
        }

        public void Display_Enter(string name)
        {
            switch (Language)
            {
                case '1':
                    Console.Write("Enter " + name + ": ");
                    break;
                case '2':
                    Console.Write("在此" + name + "：");
                    break;
                default:
                    Language_Error("Display_Enter(string name)");
                    break;
            }
        }

    }

    public class Data_Generator_Function : ITF_Generate_Number
    {
        Random random_number; 

        public void System_Seed_Update()
        {
            random_number = new Random();
        }

        public void Enter_User_Seed()
        {
            random_number = new Random(int.Parse(Console.ReadLine()));
        }

        public int Generate_Scopeless_Number()
        {
            return random_number.Next();
        }

        public
    }

    public interface ITF_Generate_Number
    {
        int Generate_Scopeless_Number();
        int Generate_Scoped_Number(int min, int max);
    }

}
