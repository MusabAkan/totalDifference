class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir dizi sayıyı boşlukla ayırarak girin:");
        string input = Console.ReadLine();
        const int @int = 67;
        string[] numbers = input.Split(' ');
        int totalDifference = default(int);

        foreach (string numberStr in numbers)
        {
            int number = int.Parse(numberStr);

            if (number < @int)
                totalDifference += @int - number;
            else
            {
                int difference = number - @int;
                totalDifference += difference * difference;
            }
        }

        Console.WriteLine("Sonuç: " + totalDifference);
    }
}