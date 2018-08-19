using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args) 
        {
            //This method is basically gathering data
            Console.Write("Type your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please also type your last name: ");
            string lastName = Console.ReadLine();

            DisplayResult(SortString(firstName),
                SortString(lastName));

            Console.ReadLine();
        }
            //This method is take individual characters from previous method to sort
            //sorting each string from UPPER case, then alphabetically
        private static string SortString(string name) 
        {
            char[] nameArray = name.ToCharArray();
            Array.Sort(nameArray);
            return String.Concat(nameArray);
        }
           //This method is displaying the sorted string results from the above method
        private static void DisplayResult(string SortedFirstName,string SortedLastName)
        {
            //This is 'stringing' the first and last name together
            //(the " ") is to provide spacing between the names
            Console.Write(String.Concat(SortedFirstName, " ",  SortedLastName));
        }

        public static void DisplayResult(string name)
        {
            Console.Write(name);
        }
        
    }
}
