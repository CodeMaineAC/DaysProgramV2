using System;

namespace DaysProgramV2
{
    class FindDays
    {
        //Enemeration setup
        enum DaysOfTheWeek
        {
            SUNDAY = 1, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
        }
        static void Main(string[] args)
        {
            DaysOfTheWeek day; //create an instance of our Enumerator 
            int userInput;

            Console.WriteLine("Enter a number to the coresponding day of the week: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            //if user input is greater than 7 default to Monday
            if(userInput < 7)
            {
                day = (DaysOfTheWeek)userInput; //casting the user input to corresponding Day of the Week
            }
            else 
            {
                Console.WriteLine("There is non day of the week that corresponds to that value");
                day = DaysOfTheWeek.MONDAY;
                userInput = 2;
            } 
            
            //alternative shortcut for simple if-else
            //day = (userInput < 7) ? (DaysOfTheWeek)userInput : DaysOfTheWeek.MONDAY; 


            Console.WriteLine("{0}th day of the week is {1}", userInput, day);
        }
    }
}
