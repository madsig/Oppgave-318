namespace OppD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!int.TryParse(args[0], out var startValue))
            {
                Console.WriteLine("Feil parameter \n Startverdi Sluttverdi Differanse");
                return;
            }
            if (!int.TryParse(args[1], out var endValue))
            {
                Console.WriteLine("Feil parameter \n Startverdi Sluttverdi Differanse");
                return;
            }
            if (!double.TryParse(args[2], out var difference))
            {
                Console.WriteLine("Feil parameter \n Startverdi Sluttverdi Differanse");
                return;
            }
            
            var length = (int)Math.Ceiling((endValue - startValue) / difference);
            var resultArr = new int[length+1];

            var index = 0; // :(
            for (var i = startValue; i <= endValue; i += (int)difference)
            {
                resultArr[index] = i;
                index++;
            }

            foreach (var num in resultArr)
            {
                Console.Write($"{num} ");
            }
        }
    }
}