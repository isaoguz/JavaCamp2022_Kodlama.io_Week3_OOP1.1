using System;

namespace YouTubeEgitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar1 = { 1, 2, 3 };
            int[] sayilar2 = { 10, 20, 30 };
            sayilar1 = sayilar2;

            sayilar2[0] = 1000;

            Console.WriteLine(sayilar1[0]);
        }
    }
}
