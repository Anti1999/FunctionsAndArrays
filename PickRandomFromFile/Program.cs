﻿using System;
using System.IO;

namespace PickRandomFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            randomFood = GetRandomFromFile("foods.txt");
            randomDrink = GetRandomFromFile("drinks.txt");
            randomMovie = GetRandomFromFile("movies.txt");
            Console.WriteLine($"Tonight you will have some {randomFood}, with {randomDrink} and watch {randomMovie} ");

        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, someArray.Length);
            return RandomIndex;

        }
        private static string GetRandomFromFile (string fileName)
        {
            string filePath = $@"C:\Users\...\Samples\{fileName}";

            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElements = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElements;
        }
    }
}