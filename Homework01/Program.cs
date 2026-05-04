namespace Homework01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入整數數值(用,分隔):");
            string[] input = Console.ReadLine().Split(',');
            string result = String.Join(",", input.Reverse());
            Console.WriteLine(result);
        }
    }
}
