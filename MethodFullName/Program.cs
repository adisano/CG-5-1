using System;

namespace MethodFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input
            Console.WriteLine("Please enter your first name:");
            //acquire user first name
            string userNameFirst = Console.ReadLine();
            //prompt user for input
            Console.WriteLine("Please enter your last name:");
            //acquire user last name
            string userNameLast = Console.ReadLine();

            //execute the method CombineNames with the parameters of userNameFirst and userNameLast
            CombineNames(userNameFirst, userNameLast);

            //keep the program open until user hits enter or closes it
            Console.ReadLine();

        }

        //pass the parameters into the variables nameFirst and nameLast
        private static string CombineNames(string nameFirst, string nameLast)
        {
            //concatenate the strings
            string nameFull = nameFirst + " " + nameLast;
            //print the result
            Console.WriteLine(nameFull);
            //pass the result back outside these code brackets
            return nameFull;

        }
    }
}
