using JSON_Data_Reading;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        FileReader fileReader = new();

        foreach (string fileName in fileReader.FileNames!)
        {
            //Console.WriteLine(fileName);

            string json = File.ReadAllText(fileName);
            User? user = JsonSerializer.Deserialize<User>(json);
            Console.WriteLine(user!.ToString());
        }
    }
}