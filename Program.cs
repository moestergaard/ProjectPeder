using System;

namespace ProjectPeder
{
    class Program
    {
        public static Boolean Done = false;
        public static Int32 TotalWorkingHoursWeekdays = 0;
        public static Int32 TotalWorkingHoursWeekends = 0;

        public static String[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public static Int32 dayNumber = 0; 

        // Enter more variables here if needed.


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Call the method
            GetInformation();
            PrintData();
        }
        
        /// <summary>
        /// This method will get information from the user.
        /// </summary>

        static void GetInformation()
        {
            Console.WriteLine("Getting Information");

            while(!Done)
            {
                // You may want to change the text here.
                Console.WriteLine("Enter a string: ");
                String? str = Console.ReadLine();
                if(str != null) {
                    UpdateInformation(str);
                }
        
                // Give the user a text that tells them what information you want.
                // Maybe use the method UpdateDate() to update the date after each input.
            }
        }

        /// <summary>
        /// This method will update the information.
        /// </summary>
        /// <param name="str"></param>
        /// Take care of each possible input string and update the information accordingly.
        static void UpdateInformation(String str)
        {
            if (str.ToLower().Contains("help"))
            {
                Console.WriteLine(
                    "\n********************************* \n " +
                    "Enter 'done' to exit the program. \n " +
                    "Enter 'help' to get help. \n" +
                    "********************************* \n ");
            }
            else if (str.ToLower().Contains("done"))
            {
                Done = true;
            }

            // Take care of inputs of data that is not 'done' or 'help'
            // For example, if the user enters working hours, you can update variables that keep track of the total working hours.
            else
            {
                Console.WriteLine("You entered: " + str);
            }
        }

        static void UpdateDate()
        {
            // This method will update the date.
            // You can use the variables day and dayNumber to keep track of the date.
        }

        /// <summary>
        /// Here you can print the information you have gathered, and style as you wish.
        /// See the example in UpdateInformation() for how to print a string with multiple lines.
        /// If you want to print a variable, you can use the + operator.
        /// </summary>
        static void PrintData() 
        {
            Console.WriteLine("\n \nPrinting Data");
            Console.WriteLine("Total working hours weekdays: " + TotalWorkingHoursWeekdays);
            Console.WriteLine("Total working hours weekends: " + TotalWorkingHoursWeekends);
            Console.WriteLine("day: " + day[dayNumber]);
        }
    }
}