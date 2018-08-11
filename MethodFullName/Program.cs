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
            //initialize string nameFull (within Main) using this method and these parameters
            string nameFull = CombineNames(userNameFirst, userNameLast);

            Console.WriteLine(nameFull);

            //keep the program open until user hits enter or closes it
            Console.ReadLine();

        }

        //pass the parameters into the variables nameFirst and nameLast
        private static string CombineNames(string nameFirst, string nameLast)
        {
            //concatenate the strings
            string nameFull = nameFirst + " " + nameLast;
            //pass the result back outside these code brackets
            return nameFull;

        }
    }
}
