using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();

        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "salati ", "prae", " kana", "pizza", "hamburgeri" };
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, foods.Length);

            string randomFoood = foods[RandomIndex];
            Console.WriteLine($"Arvuti valis söögiks: {randomFoood}");
        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "Coca-cola ", "Pepsi", " Mahla", "Vee", "Kalja" };
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, drinks.Length);

            string randomDrink = drinks[RandomIndex];
            Console.WriteLine($"Arvuti valis joogiks: {randomDrink}");
        }
        private static void DisplayRandomMovie()
        {
            string[] movies = { "Mehed ei nuta ", "Klassi kokkutulek", " Tõde ja õigus", "Kevade", "Suvi" };
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, movies.Length);

            string randomMovie = movies[RandomIndex];
            Console.WriteLine($"Arvuti valis filmiks: {randomMovie}");
        }

    } 
}
