// Homework for lesson 2, #10
Console.WriteLine("Enter the number");
int num = int.Parse(Console.ReadLine()); int first_num = num / 100; int for_get_second_num = first_num * 100; int second_num = (num - for_get_second_num) / 10;
if (num > 99 && num < 1000)
    {
    Console.WriteLine(second_num);
    }
else
    {
    Console.WriteLine("This number is not three-digit number");
    }