// Homework for lesson 2, #15
Console.WriteLine("Enter the number");
int num = int.Parse(Console.ReadLine()); 
if (num > 0 && num < 8)
    {
        if (num == 6 || num == 7)
            {
            Console.WriteLine("Yes");
            }
        else
            {
            Console.WriteLine("No");
            }
    }
else
    {
    Console.WriteLine("This number isn't a day of week");
    }