namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        //Part 1
        int a = 10;
        int b = 5;
        int c = 15;
        Console.WriteLine(a > b);
        Console.WriteLine(a < c);
        Console.WriteLine(a > b && a > c);
        Console.WriteLine(a > b || a > c);
        //Part 2
        bool israining = true;
        bool haveUmbrella = false;
        Console.WriteLine(israining + "Take an umbrella");
        Console.WriteLine(haveUmbrella + "You're good to go!");
        //Part 3
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 5)
        {
            Console.WriteLine("Tickets are free!");
        }
        else if (age > 5 && age <= 12)
        {
            Console.WriteLine("Child tickets are 5$");
        }
        else if (age > 13 && age <= 64)
        {
            Console.WriteLine("Standard tickets are $10");
        }

        else
        {
            Console.WriteLine("Senior tickets are $6");
        }
        //Part 4
        int Day = Convert.ToInt32(Console.ReadLine());
         switch (Day) 
            {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
                case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
            }
    



       


    }
}
