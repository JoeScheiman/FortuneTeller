using System;

namespace FortuneTeller
{
    class Program
    {

        //enum Colors { Red, Orange, Yellow, Green, Blue, Indigo, Violet };
        static void Main(string[] args)
        {


            //int WeekdayStart = (int)Colors.Mon;
            //int WeekdayEnd = (int)Colors.Fri;

            //Console.WriteLine("Monday: {0}", WeekdayStart);
            //Console.WriteLine("Friday: {0}", WeekdayEnd);
            //Console.ReadKey();


            //Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("Hello, get ready to read your fortune!\n");

            Console.WriteLine("...Please enter your FIRST name: ");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("...Please enter your LAST name: ");
            string userLastName = Console.ReadLine();

            Console.WriteLine("...Please enter your AGE: ");
            string userAge = Console.ReadLine();

            Console.WriteLine("...Please enter your BIRTH MONTH (1-12): ");
            string userBirthMonth = Console.ReadLine();

            Console.WriteLine("...Please enter your favorite ROYGBIV Color (type 'Help' if you don't understand): ");
            string userColor = Console.ReadLine();
            if (userColor.ToLower().Equals("help"))
            {
                Console.WriteLine("---ROYGBIV Colors are the basic colors that humans perceive...\n Red, \n  Orange, \n   Yellow, \n    Green," +
                    "\n     Blue, \n      Indigo, \n      Violet\n Enter one of those: ");
                userColor = Console.ReadLine();
            }

            Console.WriteLine("...Please enter how MANY SIBLINGS you have: ");
            string userNumSibsString = Console.ReadLine();

            //////////Retirement Years
            int retirementYears = 0;
            if ((System.Convert.ToInt32(userAge) % 2) == 0)
                retirementYears = 13;
            else
                retirementYears = 11;

            //////////Vacation Home Location
            int userNumSibsInt = System.Convert.ToInt32(userNumSibsString);
            string vacationHome = null;
            if (userNumSibsInt == 0)
                vacationHome = "Cleveland, OH";
            else if (userNumSibsInt == 1)
                vacationHome = "Your Mama's Attic, quadrant 3";
            else if (userNumSibsInt == 2)
                vacationHome = "That Place Which Cannot be Mentioned";
            else if (userNumSibsInt == 3)
                vacationHome = "Somewhere in Hawaii AND A Spot in Europe";
            else if (userNumSibsInt > 3)
                vacationHome = "16' of Oil Pipeline in Alaska";
            else
                vacationHome = "200 homes";

            //////////Mode of Transportation

            





            

        }
    }
}
