namespace MonteCarlo;

internal class Program
{
    static void Main(string[] args)
    {
        var input = new List<float>();
        var text = File.ReadAllText(Config.InputPath);
        string[] words = text.Split(Config.Splitter);

        foreach (string word in words)
        {
            float cislo = float.Parse(word);
            input.Add(cislo);
        }

        var random = new Random();


        for (float i = 0; i < Config.Permutations; i++)
        {
            var buffer = new List<float>();
            buffer.AddRange(input);
            float sum = 0;
            for (int j = 0; j < Config.Percentage; j++)
            {
                var rng = random.Next(0, buffer.Count);
                sum = sum + buffer[rng];
                //Console.WriteLine(buffer[rng]);
                buffer.Remove(buffer[rng]);
            }
            using (StreamWriter outputFile = new StreamWriter(Config.OutputPath, true))
            {
                outputFile.WriteLine(sum/Config.Percentage);
            }
            Console.WriteLine(i/100 + "%");
        }

        Console.WriteLine("100%");










    }
}
