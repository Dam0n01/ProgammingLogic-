using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        //Problem 1
        for (int p1 = 1; p1 < 11; p1++)
        {
            Console.WriteLine(p1);
        }
        //Problem 2
        for (int p2 = 1; p2 < 21; p2++)
        {

            if (p2 % 2 == 0)
                Console.WriteLine(p2);

        }
        //Problem 3
        int p3 = 5;
        while (p3 >= 1)
        {
            Console.WriteLine(p3);
            p3--;
        }
        //Problem 4
        int p4 = 10;
        while (p4 <= 1000)
        {
            if (p4 % 10 == 0)
            {
                Console.WriteLine(p4);
            }
            p4++;
        }
        //Problem 5
        string[] seasons = { "spring", "Summer", "Autumn", "Winter" };

        foreach (string seasonss in seasons)
        {

            Console.WriteLine(seasonss);
        }
        //Problem 6
        string[] Days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        int Day = Convert.ToInt32(Console.ReadLine());
        if (Day >= 0 && Day < Days.Length)
        {
            Console.WriteLine("The day is " + Days[Day]);
        }
        else
        {
            Console.WriteLine("Invalid day number.");
        }
        //Problem 7
        string[] Books = new string[3]

        {
            "Vampire Hunter D",
            "Rangers Apprentice",
            "Journey To The West",

        };

        string[] Authors = new string[3]
        {
            "Hideyuki Kikuchi",
            "John Flanagan",
            "Wu Cheng'en",
        };
        for (int i = 0; i < Books.Length; i++)
        {
            Console.WriteLine(Books[i] + "by" + Authors[i]);
        }
        //Problems 8
        int[] Temperatures = { 69, 68, 66, 65, 64 };
        Array.Sort(Temperatures);
        foreach (int tempature in Temperatures)
        {
            Console.WriteLine(tempature);
        }
        //Problem 9
        int[] Numbers = { 5, 4, 3, 2, 1, };
        Array.Reverse(Numbers);
        foreach (int number in Numbers)
        {
            Console.WriteLine(number);
        }

    }

}
        
