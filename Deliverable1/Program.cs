using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)

        {
            string vacationType;
            
            


            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous?");
            vacationType = Console.ReadLine();

            Console.WriteLine("How many are in your group?");
            int groupSize = int.Parse(Console.ReadLine());

            if (vacationType == "musical" && groupSize <= 2)
            {
                string result = ("Since your a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a first class trip to New Orleans");
                Console.WriteLine(result);
            }
            else
            
            if (vacationType == "musical" && groupSize <=5)
            {
                string result = ("Since your a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a helicopter to New Orleans");
                Console.WriteLine(result);
            }
            
            if (vacationType == "musical" && groupSize >=6)
            {
                string result = ("Since your a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a charter flight to New Orleans");
                Console.WriteLine(result);
            }

            if (vacationType == "tropical" && groupSize <=2)
            {
                string result = ("Since your a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a first class trip to a beach vacation in Mexico");
                Console.WriteLine(result);
            }
            else

            if (vacationType == "tropical" && groupSize <=5)
            {
                string result = ("Since your a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a helicopter to a beach vacation in Mexico");
                Console.WriteLine(result);
            }

            if (vacationType == "tropical" && groupSize >=6)
            {
                string result = ("Since your a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a charter flight to a beach vacation in Mexico");
                Console.WriteLine(result);
            }

            if (vacationType == "adventurous" && groupSize <=2)
            {
                string result = ("Since your a group of " + groupSize + " going on an " + vacationType + " vacation, you should take a first class trip whitewater rafting the Grand Canyon");
                Console.WriteLine(result);
            }
            else

            if (vacationType == "adventurous" && groupSize <=5)
            {
                string result = ("Since your a group of " + groupSize + " going on an " + vacationType + " vacation, you should take a helicopter to go whitewater rafting the Grand Canyon");
                Console.WriteLine(result);
            }

            if (vacationType == "adventurous" && groupSize >=6)
            {
                string result = ("Since your a group of " + groupSize + " going on an " + vacationType + " vacation, you should take a charter flight to go whitewater rafting the Grand Canyon");
                Console.WriteLine(result);
            }

        }
    }
}
