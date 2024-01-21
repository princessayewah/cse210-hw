using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int user_number = -1;
        do {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            user_number = int.Parse(Console.ReadLine());

            if (user_number != 0)
            {
            numbers.Add(user_number);  
            }
        } while (user_number != 0);
        
        //COMPUTE SUM
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        //COMPUTE AVERAGE
        float average = ((float)sum) / numbers.Count; 
        Console.WriteLine($"The average is {average}");

        //COMPUTE MAX
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest is {max}");
    }
}