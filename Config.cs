namespace MonteCarlo;

public static class Config
{
    // How many items do you want to choose from the base range
    public static int Percentage = 6;

    // Path to your input file
    public static string InputPath = "C:\\Users\\jakub.jaros\\Desktop\\test.txt";

    // Path to your output file
    public static string OutputPath = "C:\\Users\\jakub.jaros\\Desktop\\output.txt";

    // How to split the individual data
    public static string Splitter = "\r\n";

    public static int Permutations = 10000;
}