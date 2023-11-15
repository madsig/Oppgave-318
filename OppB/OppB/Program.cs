namespace OppB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputString = MakeString(args);
            Console.WriteLine($"Input: {inputString}");

            var reveresString = ReverseString(inputString);
            Console.WriteLine($"Output: {reveresString}");
        }

        static string MakeString(string[] array)
        {
            var result = "";
            foreach (var word in array)
            {
                result += word + " ";
            }
            result = result.Trim();
            return result;
        }
        static string ReverseString(string str)
        {
            var result = "";
            while (str.Length > 0)
            {
                result += str[^1];
                str = str.Remove(str.Length-1, 1);
            }
            return result;
        }
    }
}