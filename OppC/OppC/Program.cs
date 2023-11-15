namespace OppC
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Skriv in kul linje med tekst:");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Feil med input");
                return;
            }
            input = RemoveSpecialCharacters(input);
            var inputArr = input.Split(' ');

            Console.WriteLine($"Teksten din har {FindUniqueWordCount(inputArr)} ord");
            Console.WriteLine($"Ordet {FindLongestWord(inputArr)} er det lengste ordet med {FindLongestWord(inputArr, true)} bokstaver");
        }

        private static string RemoveSpecialCharacters(string input)
        {
            var newString = "";
            foreach (var c in input)
            {
                if (char.IsLetter(c) || c == ' ') newString += c;
            }
            return newString;
        }

        private static int FindUniqueWordCount(string[] arr)
        {
            var wordCount = arr.Select(word => word.ToLower()).Distinct().Count();
            return wordCount;
        }

        private static string FindLongestWord(string[] array, bool num = false)
        {
            var longestWord = "";
            foreach (var word in array)
            {
                if (word.Length > longestWord.Length) longestWord = word;
            }
            return num ? longestWord.Length.ToString() : longestWord;
        }
    }
}