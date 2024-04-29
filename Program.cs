namespace MonteCarlo;

internal class Program
{
    static void Main(string[] args)
    {
        var input = new List<int>();
        var text = File.ReadAllText(Config.InputPath);
        Console.WriteLine(text);
        string[] words = text.Split(Config.Splitter);

        foreach (string word in words)
        {
            int cislo = Int32.Parse(word);
            input.Add(cislo);
        }
        Console.WriteLine(input[3] + input[5]);


        Console.ReadLine();

        //int cislo = Int32.Parse(input);





        //var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //var random = new Random();
        //int sum = 0;

        //for (int i = 0; i < Config.Percentage; i++)
        //{
        //    var rng = random.Next(0, numbers.Count);
        //    sum = sum + numbers[rng];
        //    Console.WriteLine(numbers[rng]);
        //    numbers.Remove(numbers[rng]);
        //}


        //Console.WriteLine(sum);









    }
}
