namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int midle = number.Length / 2;

            if (number.Length == 1)
            {
                Console.WriteLine(number[0]);

            }
            else if (number.Length % 2 == 0)
            {
                Console.WriteLine(number[midle - 1]);
                Console.WriteLine(number[midle]);
            }
            else
            {
                Console.WriteLine(number[midle - 1]);
                Console.WriteLine(number[midle]);
                Console.WriteLine(number[midle - 1]);
            }
        }
    }
}
