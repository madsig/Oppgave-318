using System.Security.Cryptography;

namespace OppE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var board = new[]
            {
                0, 1, 3,
                4, 2, 5,
                7, 8, 6
            };
            var correctBoard = new[]
            {
                1, 2, 3,
                4, 5, 6,
                7, 8, 0,
            }; 

            var input = "";
            while (!board.SequenceEqual(correctBoard))
            {
                PrintBoard(board);
                Console.WriteLine("\nSkriv tallet du vil bytte med 0: ");
                input = Console.ReadLine();
                Console.WriteLine("");
                var inputInt = int.Parse(input);
                board = SlideNum(board, inputInt);
            }

            PrintBoard(board);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gratulerer! Du greide det :)");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void PrintBoard(int[] array)
        {
            for (double i = 0; i < array.Length; i++)
            {
                Console.Write(array[(int)i]);
                Console.Write(", ");
                if ((i+1)/3 == Math.Floor((i+1)/3)) Console.Write("\n");
            }
        }

        private static int[] AllowedMoves(int index)
        {
            var array = new int[] {index-1, index-3, index+1, index+3}; 
            return array;
        }

        private static int[] SlideNum(int[] array, int num)
        {
            var zeroIndex = Array.IndexOf(array, 0);
            var numIndex = Array.IndexOf(array, num);
            var allowedMoves = AllowedMoves(zeroIndex);

            if (!allowedMoves.Contains(numIndex))
            {
                Console.WriteLine("Invalid move");
                return array;
            } 
            
            array[zeroIndex] = num;
            array[numIndex] = 0;

            return array;
        }
}
}