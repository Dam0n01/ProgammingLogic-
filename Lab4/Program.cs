namespace Lab4;

class Car
{
    public string model;
    public string color;
    public int year;

    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }

    //Problem 1
    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }
    //Problem 2
    public void Drive(int miles)
    {
        Console.WriteLine($"Drove {miles} miles.");
    }
    //Problem 3
    public string GetDescription()
    {
        return $"{year}{color}{model}";
    }
    //Problem 4
    public string Repaint(string newColor)
    {
        Console.WriteLine($"The car has been repainting to{newColor}.");
        return newColor;
    }

}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display();
        myCar.Start();
        myCar.Drive(50);
        Console.WriteLine(myCar.GetDescription());
        myCar.Repaint("Red");
    }

}