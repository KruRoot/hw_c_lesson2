// Homework for lesson 2, #13
Console.WriteLine("Enter the number");
int num = int.Parse(Console.ReadLine());
int logarithm = (int)Math.Log10(num)-2; 
if (num > 99)
    {
    Console.WriteLine(num % (int)Math.Pow(10, logarithm + 1) / (int)Math.Pow(10, logarithm));
    }
else
    {
    Console.WriteLine("This number doesn't have a third digit");
    }