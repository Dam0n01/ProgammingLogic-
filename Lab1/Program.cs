using System.Diagnostics.Contracts;

namespace Lab1;
// Damon Bailey
// It Logic Progamming 1050
class Program
{
    static void Main(string[] args)
    {
        // Step 2
        Console.WriteLine("Damon Bailey, IT- 1050 LogicProgamming");

        //Step 3
        int Number = 15;
        string Language = "C#";
        double Programming = 0D;
        bool Experience = false;
        int Temp = 78;
        Console.WriteLine("My favote number is:" + Number);
        Console.WriteLine("The current Language I like is" + Language);
        Console.WriteLine("I have currently programmed a total of:" + Programming + "times offically.");
        Console.WriteLine(Experience + "None");
        Console.WriteLine("the current tempature" + Temp + "degrees");
        // Step 4
        const string School = "Tri-c Westshore";
        Console.WriteLine("I currently go to:" + School);
        //Step 5
        double Deci = 9.78;
        int DDeci = (int)Deci;
        Console.WriteLine(Convert.ToString(DDeci));
        Console.WriteLine(Convert.ToString(Experience));
        Console.WriteLine("double" + Deci);
        //Step 6
        Console.WriteLine("Enter name:");
        string Name = Console.ReadLine();
        Console.WriteLine("Hello:" + Name);
        Console.WriteLine("Enter your age");
        // Step 7
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is:" + age);
        int Num1 = 15;
        int Num2 = 20;
        int Sum1 = Num1 + 10;
        int Sum2 = Num2 + 10;
        int Diff1 = Num1 - 2;
        int Diff2 = Num2 - 2;
        int Multi1 = Num1 * 3;
        int Multi2 = Num2 * 3;
        int Divi1 = Num1 / 2;
        int Divi2 = Num2 / 2;
        int Mod1 = Num1 % 2;
        int Mod2 = Num2 % 2;
        Console.WriteLine("The sume of 20 + 10 is:"+ Sum2);
        Console.WriteLine("The sum of 15 + 10 is:" + Sum1);
        Console.WriteLine("The difference of 15 - 2 is:"+ Diff1);
        Console.WriteLine("The difference of 20 - 2 is:"+ Diff2);
        Console.WriteLine("The total of 15 * 3 is:"+ Multi1);
        Console.WriteLine("The total of 20 * 3 is:");
        Console.WriteLine("The qoutient of 15/2 is:"+ Divi1);
        Console.WriteLine("The qoutient of 20/2 is:"+Divi2);
        Console.WriteLine("The remainder of 15%2 is:" + Mod1);
        Console.WriteLine("The remainder of 20%2 is:" + Mod2);
        //Step 8
        double DoubleVar = 1.123456789D;
        float FloatVar = 1.123456789F;
        Console.WriteLine("Float Variable" + FloatVar);
        Console.WriteLine("Double Variable" + DoubleVar);
        //Step 9
        int IncreDecre = 10;
        IncreDecre++;
        IncreDecre--;
        Console.WriteLine(IncreDecre);


    }
}
