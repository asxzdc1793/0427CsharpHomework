namespace Homework02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一個整數:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string result = String.Join("", Enumerable.Repeat(n - i, i + 1));
                Console.WriteLine(result);
            }
        }
    }
}
