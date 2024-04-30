namespace MonteCarlo;

public static class Config
{
    // How many items do you want to choose from the base range
    public static int Percentage = 5204;

    // Path to your input file *.txt
    public static string InputPath = "C:\\Users\\jakub.jaros\\Downloads\\Uproot_input.txt";

    // Path to your output file *.txt (the file will be created)
    public static string OutputPath = "C:\\Users\\jakub.jaros\\Desktop\\Uproot_output.txt";

    // How to split the individual data
    public static string Splitter = "\r\n";

    //How many permutation do you want to execute
    public static int Permutations = 10000;
}