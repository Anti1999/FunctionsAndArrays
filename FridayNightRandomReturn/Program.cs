using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] foods = { "salat", "praad", " kana", "pizza", "hamburger" };
            string[] drinks = { "coca-cola ", "pepsi", " mahl", "vesi", "kali" };
            string[] movies = { "Mehed ei nuta ", "Klassi Kokkutulek", " Tõde ja Õigus", "Kevade", "Suvi" };

            randomFood = PickRandomElementFromArray(foods);
            randomDrink = PickRandomElementFromArray(drinks);
            randomMovie = PickRandomElementFromArray(movies);

            Console.WriteLine($"Täna õhtul söögiks {randomFood}, joogiks on {randomDrink} ja vaatate filmi {randomMovie}. ");
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, someArray.Length);
            return RandomIndex;

        }
        private static string PickRandomElementFromArray(string[] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;


        }
    }
}
       