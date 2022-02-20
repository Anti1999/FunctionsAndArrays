using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomDrink();
            DisplayRandomFood();
            DisplayRandomMovie();

        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, someArray.Length);
            return RandomIndex;

        }
        private static void DisplayRandomFood()
        {
            string[] foods = { "Salati ", "Prae", " Kana", "Pizza", "Hamburgeri" };


            Console.WriteLine($"Arvuti valis söögiks: {foods[GenerateRandomIndex(foods)]}");
        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "Coca-cola ", "Pepsi", " Mahla", "Vee", "Kalja" };

            Console.WriteLine($"Arvuti valis joogiks: {drinks[GenerateRandomIndex(drinks)]}");
        }
        private static void DisplayRandomMovie()
        {
            string[] movies = { "Mehed ei nuta ", "Klassi Kokkutulek", " Tõde ja Õigus", "Kevade", "Suvi" };

            Console.WriteLine($"Arvuti valis filmiks: {movies[GenerateRandomIndex(movies)]}");
        }
    }
}   
