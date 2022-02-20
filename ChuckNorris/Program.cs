using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomChuck;
            randomChuck = GetRandomFromFile("chuck.txt");
            
            Console.WriteLine(randomChuck);
        }
        private static int GenerateRandomIndex(string[] array)
        {
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, array.Length);
            return RandomIndex;

        }
        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\Anti\Samples\{fileName}";

            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElements = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElements;
        }
    }
}
